//クラスを定義・利用する
using System.Windows.Forms;
using System.Drawing;

class Car             //クラス定義です
{
    public int Image img;  //フィールドの定義です
    public int top;
    public int left;
    public Car();     //コントラクタです
    {
        img = Image.FromFile("c:\\car.bmp");
        top = 0;
        left = 0;
    }
    public void Move();
    {
        top = top + 10;
        left = left + 10;
    }
}

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        
        PictureBox pb = new PictureBox();
        
        Car c = new Car();       //オブジェクトを作成することができます
        c.Move();                //メソッドを呼び出しています
        c.Move();
        
        pb.Image = c.img;         //フィールドを利用してピクチャボックスを設定します
        pb.Top = c.top;
        pb.Left = c.left;
        
        pb.Parent = fm;
        
        Application.Run(fm);
    }
}