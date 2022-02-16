//アニメーションを行う
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

class Sample7 : Form
{
    private ball bl;
    private int x, y;

    public static void Main()
    {
        Application.Run(new Sample7());
    }
    public Sample7()
    {
        this.Text= "サンプル"
        this.ClientSize = new Size(250, 100);

        bl = new ball();

        Point p = new Point(0, 0);
        Color c = Color.Blue;

        bl.Point = p;
        bl.Color = c;

        x = 2;
        y = 2;

        Timer tm = new Timer();     //タイムオブジェクトを作成します
        tm.Interval = 100;          //間隔をミリ秒で指定します
        tm.Start();                 //タイマーを開始します

        this.Paint += new PaintEventHandler(fm_Paint);
        tm.Tick += new EventHandler(tm_Tick);     //イベントハンドラを登録します
    }
    public void fm_Paint(Object sender, PaintArgs e)
    {
        Graphics g = e.Graphics;

        Point p = bl.Point;
        Color c = bl.Color;
        SolidBrush br = new SolidBrush(c);

        int x = p.X;
        int y = p.Y;
        g.FillEllipse(br, x, y, 10, 10);
    }
    //指定ミリ秒ごとにイベントハンドラが処理されます
    public void tm_Tick(Object sender, EventArgs e)
    {
        Point p = bl.Point;

        //壁にあたったら反転させます
        if (p.X < 0 || p.X > this.ClientSize.Width - 10) x = -x;
        if (p.Y < 0 || p.Y > this.ClientSize.Height - 10) y = -y;

        //移動させます
        p.X = p.X + x;
        p.Y = p.Y + y;

        //再描画させます
        bl.Point = p;
        this.Invalidate();
    }
}

class ball
{
    public Color color;
    public Point Point;
}