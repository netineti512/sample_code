//if文を使う
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 300;
        fm.Height = 200;
        
        PictureBox pb = new PictureBox();
        pb.Image = Image,FormFile("c:\\car.bmp");
        pb.Left  200;
        
        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Text = "車です。";
        
        if (pb.Left >= 150)
        {
            lb.Text = "車は東にあります。";
        }
        
        pb.Parent = fm;
        lb.Parent = fm;
        
        Application.Run(fm);
    }
}