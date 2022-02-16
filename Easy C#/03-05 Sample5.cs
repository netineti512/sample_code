//ピクチャボックスを中央に表示する
using System.Windows.Forms;
using System.Drawing;

class Sample5
{
    publc static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        
        PictureBox pb = new PictureBox();
        pb.Image = Image.FormFile("c:\\car.bmp");
        pb.Top = (fm.Height - pb.Height) / 2;       //上端位置を計算しています
        pb.Left = (gm.Width - pb.Width) / 2;        //左端位置を計算しています
        
        pb.Parent = fm;
        
        Application.Run(fm);
    }
}