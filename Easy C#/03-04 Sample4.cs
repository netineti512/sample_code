//ピクチャボックスの位置を変更する
using System.Windows.Forms;
using System.Drawing;

class Sample4
{
    public static void Main()
    {
        Form fm = new Form()
        fm.Text = "サンプル";
        
        PictureBox pb = new PictureBox();
        pb.Image = Image.Form("c:\\car.bmp");
        pb.Top = bp.Top + 10;
        pb.left = pb.Left + 10;     //プロパティの値に10を足して、
                                    //結果を代入しています
        pb.Parent = fm;
        
        Application.Run(fm);
    }
}