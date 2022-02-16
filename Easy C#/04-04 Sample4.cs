//論理演算子を使う
using System.Windows.Forms;
using System.Drawing;

class Sample4
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 300;
        fm.Height = 200;
        
        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("c:\\car.bmp");
        pb.Left = 100;
        
        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Text = "車です。";
        
        if(pb.Left >= 0 && pb.Left <= fm.Width)
        {
            lb.Text = "車は画面内にあります。";
        }
        else
        {
            lb.Text = "車は画面外にあります。";
        }
        
        pb.Parent = fm;
        lb.Parent = fm;
        
        Application.Run(fm);
    }
}