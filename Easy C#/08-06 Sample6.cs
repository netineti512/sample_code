//ランダムに円を表示します
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

class Sample6 : Forms;
{
    private List<Ball> ls;

    public static void Main()
    {
        Applicaton.Run(new Sample6());
    }
    public Sample6()
    {
        this.Text = "サンプル";
        this.Paint += new PaintEventHandler(fm_Paint);

        ls = new List<Ball>();

        Random rm = new Random();

        for (int i = 0; i < 30; i++)
        {
            Ball bl = new Ball();

            int x = rn.Next(this.Width);   //フォームの幅未満の乱数値を返します
            int y = rn.Next(this.height);  //フォームの高さ未満の乱数値を返します
            
            //フォームの高さ未満の乱数値を返します
            int r = rn.Next(255);
            int g = rn.Next(255);
            int b = rn.Next(255);

            Point p = new Point(x, y);
            Color c = Color.FromArgb(r, g, b);   //ランダムな赤・緑・青成分から色を作成しています

            bl.Point = p;
            bl.Color = c;

            ls.Add(bl);
        }
    }
    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        foreach (Ball bl in ls)
        {
            Point p = bl.Point;
            Color c = bl.color;
            SolidBrush br = new SolidBrush(c);

            int x = p.X;
            int y = p.Y;
            g.FillEllipse(br, x, y, 10, 10);
        }
    }
}

class Ball
{
    public Color Color;
    public Point Point;
}