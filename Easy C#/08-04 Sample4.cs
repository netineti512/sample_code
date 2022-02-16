//円を描く
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

class Sample4 : Form
{
    private List<Point> ls;
    
    public static void Main()
    {
        Application.Run(new Sample4());
    }
    public Sample4()
    {
        this.Text = "サンプル";
        
        //クリックした位置を格納するリストを作成しています
        ls = new List<Point>();
        
        this.MouseDown += new MouseEventHandler(fm_MouseDown);
        this.Paint += new PaintEventHandler(fm_Paint);
    }
    public void fm_MouseDown(Object sender, MouseEventArgs e)   //マウスでクリックしたときに、
    {
        Point p = new Point();
        //位置を記録し、
        p.X = e.X;
        p.Y = e.Y;
        ls.Add(p);
        //描画を行います
        this.Invalidate();
    }
    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        Pen dp = new Pen(color.Black, 1);
        
        foreach (Point p in ls)
        {
            int x = p.X;
            int y = p.Y;
            g.DrawEllipse(dp, x, y, 10, 10);    //円を描画します
        }
    }
}