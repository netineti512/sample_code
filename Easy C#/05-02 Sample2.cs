//アクセス指定子を使う
using System.Windows.Forms;
using System.Drawing;

class Car
{
    private Image img;   //privateを指定してクラスの外部からアクセスできないようにする
    private int top;
    private int left;
    
    public Car()
    {
        img = Image.FromFile("c:\\car.bmp");
        top = 0;
        left = 0;
    }
    public void Move()          //publicなメソッドを定義する
    {
        top = top + 10;
        left = left + 10;
    }
    public void SetImage(Image i)     //publicなメソッドを定義できます
    {
        img = i;
    }
    public Image GetImage()            //publicなメソッドを定義できます
    {
        return img;
    }
    public int Top                  //publicなプロパティを定義できます
    {
        set { top = value; }
        get { return top; }
    }
    public int Left                 //publicなプロパティを定義できます
    {
        set { left = value; }
        get { return left; }
    }
}

class Sample2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 300;
        fm.Height = 200;
        
        PictureBox pb = new PictureBox();
        
        Car c = new Car();
        c.Move();
        c.Move();
        
        pb.Image = c.GetImage();     //publicなメソッドを介してフィールドにアクセスします
        pb.Top = c.Top;              //publicなプロパティを介してフィールドにアクセスする
        pb.Left = c.Left;
        
        pb.Parent = fm;
        
        Application.Run(fm);
    }
}