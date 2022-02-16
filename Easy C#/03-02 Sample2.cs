//別のプロパティの値を代入する
using System.Windows.Forms;
using System.Drawing;

class Sample2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.text = "サンプル";
        
        PictureBox pb = new PictureBox();
        pb.Image = Image.FormFile("c:\\car.bmp");
        pb.Top = 100;
        pb.Left = pb.Width;      //直接代入することも出来ます
        
        pb.Parent = fm;
        
        Application.Run(fm);
    }
}