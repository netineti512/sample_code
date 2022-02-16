//変数を使う
using system.Windows.Forms;
using system.Drawing;

class Sample3
{
    public static void Main()
    {
        Form fm = new form()
        fm.Text = "サンプル";
        
        int w;         //変数を宣言しています。
        w = 100;
        
        PictureBox pb = new PictureBox();
        pb.Image = Image.FormFile("c:\\car.bmp");
        pb.Top = w;
        
        pb.Parent = fm;
        
        Application.Run(fm);
    }
}