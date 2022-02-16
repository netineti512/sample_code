//画像を回転する
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample1 : Form
{
    private Image im;
    
    public static void Main()
    {
        Application.run(new Sample1());
    }
    public Sample1()
    {
        this.text = "サンプル";
        this.Width = 250;
        this.Height = 200;
        
        im = Image.FromFile("c:\\car.bmp");
        
        this.Click += new EventHandler(fm_Click);
        this.Paint += new PaintEventHandler(fm_Paint);    //描画イベントハンドラを登録します
    }
    public void fm_Click(Object sender, EventArgs e)
    {
        im.RotateFlip(RotateFlipType.Rotate90FileNone);    //回転します
        this.Invalidate();      //回転後の状態で再描画します
    }
    public void fm_Paint(Object sender, PaintEventArgs e)    //描画イベントハンドラです
    {
        Graphics g = e.Graphics;
        
        g.DrawImage(im, 0, 0);      //画像を描画します
    }
}