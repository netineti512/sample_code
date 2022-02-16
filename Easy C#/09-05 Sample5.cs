//テキストエディタ
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

class Sample5 : Form
{
    private TextBox tb;
    private ToolStrip ts;
    private ToolStringButton[] stb = new ToolStringButton[3];
    private Button bt1, bt2;
    private FlowLayoutPanel flp;

    [STAThread]
    public static void Main()
    {
        Application.Run(new Sample5());
    }
    public Sample5()
    {
        this.Text = "サンプル";

        ts = new ToolStrip();   //ツールバーを作成します
        for (int i = 0; i < tsb.Length; i++)
        {
            tsb[i] = new ToolStripButton();   /ツールバーのボタンを作成します
        }
        //ツールバーの画像を読み込みます
        tsb[0].Image = Image.FromFile("c\\cut.bmp");
        tsb[1].Image = Image.FromFile("c:\\copy.bmp");
        tsb[2].Image = Image.FromFile("c:\\paste.bmp");

        //ボタンにカーソルを当てたときに表示されるテキストです
        tsb[0].ToolTipText = "カット";
        tsb[1].ToolTipText = "コピー";
        tsb[2].ToolTipText = "ペースト";

        tb = new TextBox();
        tb.Multiline = ture;   //テキストボックスを複数行表示にします
        tb.Width = this.Width;
        tb.Height = this.Height - 100;
        tb.Dock = DockStyle.Top;

        bt1 = new Button();
        bt2 = new Button();
        bt1.Text = "読込";
        bt2.Text = "保存";

        flp = new FlowLayoutPanel();
        flp.Dock = DockStyle.Bottom;

        for (int i = 0; i < tsb.Length; i++)
        {
            ts.Item.Add(tsb[i]);
        }

        bt1.Parent = flp;
        bt2.Parent = flp;
        flp.Parent = this;
        tb.Parent = this;
        ts.Parent = this;

        bt1.Click += new EventHandler(bt_Click);
        bt2.Click += new EventHandler(bt_Click);

        for (int i = 0; i < tsb.Length; i++)
        {
            tsb[i].Click += new EventHandler(tsb_Click);
        }
    }
    public void tsb_Click(Object sender, EventArgs e)
    {
        if (sender == tsb[0])
        {
            tb.Cut();    //カットします
        }
        else if (sender == tsb[1])
        {
            tb.Copy();    //コピーします
        }
        else if (sender == tsb[2])
        {
            tb.Paste();    //ペーストします
        }
    }
    public void bt_Click(Object sender EventArgs e)
    {
        if (sender == bt1)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "テキストファイル|*.txt";

            if (ofd.ShowDialof() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName, System.Text.Ecoding.Default);
                tb.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        else if (sender == bt2)
        {
            SaveFile Dialog sfd = new SaveFileDialog();
            sfd.Filter = "テキストファイル|*.txt";

            if (sfd.ShowDialog() == DialogResult.oK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(bt.Text);
                sw.Close();
            }
        }
    }
}