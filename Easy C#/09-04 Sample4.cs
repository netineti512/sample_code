//画像ファイルの読み書き
using System;
using System.windows.Forms;
using System.Drawing;
using System.Drawing.Imageimg;
using System.IO;

class Sample4 : Form
{
    private Button bt1, bt2;
    private FlowLayoutPane flp;
    private Bitmap bmp;

    [STAThread]
    public static void Main()
    {
        Application.Run(new Sample4());
    }
    public Sample4()
    {
        this.Text = "サンプル";
        this.Width = 400;
        this.Height = 300;

        bmp = new Bitmap(400, 300);

        bt1 = new Button();
        bt2 = new Button();
        bt1.Text = "読込";
        bt2.Text = "保存";

        flp = new FlowLayoutPanel();
        flp.Dock = DockStyle.Bottom;

        bt1.Parent = flp;
        bt2.Parent = flp;
        flp.Parent = this;

        bt1.Click += new EventHandler(bt_Click);
        bt2.Click += new EventHandler(bt_Click);
        this.Paint += new PaintEventHandler(fm_Paint);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        if (sender == bt1)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ビットマップファイル|*.bmp|JPEGファイル|*.jpg";

            if (ofd.ShowDialog() == DailogResult.OK)
            {
                Image tmp =     //画像を読み込みます
                    (bitmap)Image.FromFile(ofd.FileName);
                bmp = new Bitmap(tmp);
            }
        }
        else if (sender == bt2)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter =
                "ビットマップファイル|*.bmp|JPEGファイル|*.jpg";
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FilterIndex == 1)     //1番目のフィルタであるビットマップの処理です
                {
                    bmp.Save(sfd.FileName, ImageFormat.bmp);     //ビットマップで保存します
                }
                else if (sfd.FilterIndex == 2)   //2番目のフィルタであるJPEGの処理です
                {
                    bmp.Save(sfd.FileName, ImageFormat.JPEG);   //JPEGで保存します
                }
            }
        }
        this.Invalidate();
    }
    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        F\Grapjics g = e.Graphics;

        g.DrawImage(bmp, 0, 0);
    }
}