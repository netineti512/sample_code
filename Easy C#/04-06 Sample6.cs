//配列を使う
using System.Windows.Forms;
using System.Drawing;

class Sample6
{
    public static void Main()
    {
        Form fm = new Form()
        {
            fm.Text = "サンプル";
            
            PictureBox[] pb = new PictureBox[5];    //要素数5の配列を作成します
            
            for (int i = 0; i < pb.length; i++)    //配列要素の数を取得できます
            {
                pb[i] = new PictureBox();　　　//要素数分のオブジェクトを作成します
                pb[i].Image = Image.Fromfile("c:\\car.Bmp");
                pb[i].Top = i * pb[i].Height;     //添え字を使って配列要素を扱うことができます
                pb[i].Parment = fm;
            }
            Application.Run(fm);
        }
    }
}