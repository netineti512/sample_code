//クリックピンを使う
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

class Sample5 : Form
{
    private Image im;
    
    public static void Main()
    {
        Application.Run(new Sample5());
    }
    public sample5()
    {
        im = Image.FromFile("c:\\tea.jpg");
        
        this.Text = "サンプル";
        this.ClientSize = new Size(400, 500);
        this.BackColor = Color.Black;
        
        this.Paint += new PaintEventHandler(fm_Paint);
    }
    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        GraphicsPath gp = new GraphicsPath();   //グラフィックパスを作成し、
        
        gp.AddEllipse(new Rectangle(0, 0, 400, 300));    //グラフィックパスに円を追加します
        Region rg  new Region(gp);    //グラフィックパスからリージョンを作成します
        g.Clip = rg;     //クリッピングを行います
        
        g.DrawImage(im, 0, 0, 400, 300);
    }
}