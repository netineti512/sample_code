//if～else if～else文を使う
using System.Windows.Forms;
using System.Drawing;

class Sample2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 300;
        fm.Height = 200;
        
        PictureBox pb = new PictureBox();
        pb.Image = Image.FrontFile("c:\\car.bmp");
        pb.Left = 100;
        
        LAbel lb = new label();
        lb.Top = pb.Bottom;
        lb.Text = "車です。";
        
        if (pb.Left >= 150)
        {
            lb.Text = "車は東にあります。"
        }
        else if (pb.Left <= 20)
        {
            lb.Text = "車は西に在ります。"
        }
        else
        {
            lb.Text = "車は中部にあります。"
        }
        
        pb.Parent = fm;
        lb.parent = fm;
        
        Application.Run(fm);
    }
}