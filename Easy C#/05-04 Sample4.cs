//クラスを拡張する
using System.Windows.Forms;
using System.Drawing;

class Car
{
    private Image img;
    protected int top;     //protecredメンバとしておきます
    protected int left;
    
    public Car()
    {
        img = Image.FromFile("c:\\car.bmp");
        top = 0;
        left = 0;
    }
    virtual public void Main()    //上書きされる基本クラスのメンバにvirtualをつけておきます
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
        set { left = value; }
        get { return left; }
    }
}

class RacingCar : Car
{
    override pubic void Move()
    {
        top = top + 10;
        left = left + 100;
    }
}

class Sample4
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 300;
        fm.Height = 200;
        
        PictureBox[] pb = new PictureBox[2];
        
        for(int i = 0; i < pb.length; i++)
        {
            pb[i] = new PictureBox();
            pb[i].Parent = fm;
        }
        
        Car[] c = new Car[2];    //基本クラスの型で
        c[0] = new Car();        //オブジェクトをまとめて扱うことができます
        c[1] = new RacingCar();
        
        for(int i = 0; i < c.Length; i++)
        {
            c[i].Move();
            pb[i].Image = c[i].getImage();
            pb[i].Top = c[i].Top;
            pb[i].Left = c[i].Left;
        }
        
        Application.Run(fm);
    }
}