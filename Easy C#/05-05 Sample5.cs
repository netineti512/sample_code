//既存のクラスから拡張する
using System.Windows.Forms;
using System.Drawing;

class Sample5 : Form   //Formを拡張したクラスとします
{
    public static void Main()
    {
        Application.Run(new Sample5());     //クラスからオブジェクトを作成してウィンドウプログラムを実行します
    }
    public Sample5()     //コンストラクタです
    {
        this.Text = "サンプル";     //継承されたプロパティを使って設定を行います
        this.Width = 400;
        this.Height = 200;
        this.backgroundImage = Image.FromFile("c:\\car.bmp");
    }
}