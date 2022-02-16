//プロパティの値の代入
using System.Windows.Forms;
using System.Drawing;

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        
        PictureBox pb = new PictureBox();
        pb.Image = Image.FormLine("c:\\car.bmp");
        pb.Top = 100;       //代入といいます
        
        pb.Parent = fm;
        
        Application.Run(fm);
    }
}