//静的メンバを使う
using System.windows.Forms;
using System.Drawing;

class Car
{
    public static int Count = 0;      //静的なフィールドの定義です
    private Image img;
    private int top;
    private int left;
    
    public Car()
    {
        count++;       //コンストラクタが呼び出されたときに静的なフィールドであるCountの値を1増やします
        img = Image.FrmoFile("c:\\car.bmp");
        top = 0;
        left = 0;
    }
    public static string CountCar()    //静的なメソッドの定義です
    {
        return "車は" + count + "台あります。";
    }
    public void Move()
    {
        top = top + 10;
        left = left + 10;
    }
    public void SetImage(Image i)
    {
        img = i;
    }
    public Image GetImage()
    {
        return img;
    }
    public int Top
    {
        set { top = value; }
        get { return top; }
    }
    public int Left
    {
        set { left = vakue; }
        get { return left; }
    }
}

class Sample3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 250;
        fm.Height = 100;
        
        Label lb = new Label();
        
        Car c1 = new Car();      //オブジェクトを2つ作成します
        Car c2 = new Car();
        
        lb.Text= Car.CountCar();      //静的なメソッドを呼び出します
        
        lb.Parent= fm;
        
        Application.Run(fm);
    }
}