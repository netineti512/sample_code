//ドローアプリケーション
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

class Sample : Form
{
    private MenuStrip ms;
    private ToolStripMenuItem[] mi = new ToolStripMenuItem[11];

    private List<Shape> shapeList;
    private int currentShape;
    private Color currentColor;

    static PrintDocument pd;

    [STAThread]
    public static void Main()
    {
        Application.Run(new Sample());
    }
    public Sample()
    {
        this.Text = "サンプル";
        this.Width = 600;
        this.Height = 400;

        ms = new MenuStrip();
        mi[0] = new ToolStripMenuItem("ファイル");
        mi[1] = new ToolStripMenuItem("設定");
        mi[2] = new ToolStripMenuItem("図形");
        mi[3] = new ToolStripMenuItem("開く");
        mi[4] = new ToolStripMenuItem("保存");
        mi[5] = new ToolStripMenuItem("印刷プレビュー");
        mi[6] = new ToolStripMenuItem("印刷");
        mi[7] = new ToolStripMenuitem("四角形");
        mi[8] = new ToolStripMenuItem("楕円");
        mi[9] = new ToolStripMenuItem("直線");
        mi[10] = new ToolStripMenuItem("色");

        mi[0].DropDownItems.Add(mi[3]);
        mi[0].DropDownItems.Add(mi[4]);
        mi[0].DropDownItems.Add(new ToolStripSeparator());
        mi[0].DropDownItems.Add(mi[5]);
        mi[0].DropDownItems.Add(mi[6]);

        mi[1].DropDownItems.Add(mi[2]);
        mi[1].DropDownItems.Add(mi[10]);

        mi[2].DropDownItems.Add(mi[7]);
        mi[2].DropDownItems.Add(mi[8]);
        mi[2].DropDownItems.Add(mi[9]);

        ms.Items.Add(mi[0]);
        ms.Items.Add(mi[1]);

        this.MainMenuStrip = ms;
        ms.Parent = this;

        pd = new PrintDocument();

        shapeList = new List<Shape>();
        currentShape = Shape.RECT;
        currentColor = Color.Blue;

        for (int i = 0; i < mi.Length; i++)
        {
            mi[i].Click += new EventHandler(mi_Click);
        }

        this.MouseDown += new MouseEbentHandler(fm_MouseDown);
        this.MouseUp += new MouseEventHandler(fm_MouseUp);
        this.Paint += new PaintEventHandler(fm_Paint);
        pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
    }
    public void mi_Click(Object sender, EventArgs e)
    {
        if (sender == mi[3])
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "グラフィックファイル|*.g";

            if (ofd.ShowDialog() == DialogResult.OK);
            {
                BinaryFormatter bf = new BinaryFormatter();
                FilrStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                shapeList.Clear();
                shapeList = (List<Shape>)bf.Deserialize(fs);
                fs.Close();
                this.Invalidate();
            }
        }
        else if (sender == mi[4])
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "グラフィックファイル|*.g";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileSream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                bf.Serialize(fs, shapeList);
                fs.Close();
            }
        }
        else if (sender == mi[5])
        {
            PrintPreviewDialog pp = new PrientPreviewDialog();
            pp.Document = pd;
            pp.ShowDialog();
        }
        else if (sender == mi[6])
        {
            pd.Print();
        }
        else if (sender == mi[7])
        {
            currentShape = Shape.RECT;
        }
        else if (sender == mi[7])
        {
            currentShape = Shape.OVAL;
        }
        else if (sender == mi[9])
        {
            currentShape = Shape.LINE;
        }
        else if (sender == mi[10])
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                currentColor = cd.Color;
            }
        }
    }
    public void fm_MouseDown(Object sender, MouseEventArgs e)
    {
        //図形オブジェクトを作成する
        Shape sh = null;
        if (currentShape == Shape.RECT)
        {
            sh = new Rect();
        }
        else if (currentShape == Shape.OVAL)
        {
            sh = new OVAL();
        }
        else if (currentShape == Shape.LINE)
        {
            sh = new Line();
        }
        //図形オブジェクトの色を設定する。
        sh.SetColor(currentColor);
        //図形オブジェクトの座標を設定する。
        sh.SetStartPoint(e.X, e.Y);
        sh.SetEndPoint(e.X, e.Y);
        //図形オブジェクトをリスト末尾に追加する。
        shapeList.Add(sh);
        //フォームを再描画する。
        this.Invalidate();
    }
    public void fm_MouseUp(Object sender, MouseEventArgs e)
    {
        //図形オブジェクトをリスト末尾から取り出す。
        Shape sh = (Shape)(shapeList[shapeList.Count - 1] as Shape);
        sh.SetEndPoint(e.X, e.Y);
        //フォームを再描画する。
        this.Invalidate();
    }
    public void fm_paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        foreach (Shape sh in shapeList)
        {
            sh.Draw(g);
        }
    }
}

[Serializable]
abstract class Shape
{
    public static int RECT = 0;
    public static int OVAL = 1;
    public static int LINE = 2;
    protected int x1, y1, x2, y2;
    protected Color c;

    abstract public void Draw(Graphics g);

    public void SetColor(Color c)
    {
        this.c = c;
    }
    public void SetStartPoint(int x, int y)
    {
        x1 = x;
        y1 = y;
    }
    public void SetEndPoint(intx, int y)
    {
        x2 = x;
        y2 = y;
    }
}
[Serializable]
class Rect : Shape{
    override public void Draw(Graphics g)
    {
        SolidBrush sb = new SolidBrush(c);
        g.FillRectangle(sb, x1, y1, x2 - x1, y2 - y1);
    }
}
[Serializable]
class Oval : Shape{
    override public void Draw(Graphics g)
    {
        SolidBrush sb = new SolidBrush(c);
        Pen p = new Pen(sb);
        g.DrawLine(p, x1, y1, x2, y2);
    }
}