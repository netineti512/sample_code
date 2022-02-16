//画像を表示する
using System.Windows.Forms;
using System.Drawing;

class Sample4
{
    public static void Main()
    {
        Form fm = new Form();
        fm.text = "サンプル";
        
        PictureBox pb = new PictureBox();            //画像を読み込むピクチャボックスを作成します
        pb.Image = Image.FormFike("c:\\car.bmp");    //画像を読み込みます
        pb.Parent = fm;
        
        Application.Run(fm);
    }
}