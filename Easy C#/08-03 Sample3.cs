//画像の操作
using System;
using System.Windows.Forms;
using System.Drawing;

class Sample3 : Form
{
    private Bitmap bm1, bm2;
    private int i;
    
    public static void Main()
    {
        Application.Run(new Sample3());
    }
    public Sample3()
    {
        this.Text = "サンプル";
        this.Width = 400;
        this.Height = 300;
        
        bm1 = new Bitmap("c:\\tea.jpg");
        bm2 = new Bitmap("c:\\tea.jpg");
        
        i = 0;
        
        this.Click += new EventHandler(fm_Click);
        this.Paint += new PaintEventHandler(fm_Paint);
    }
    public void convert()
    {
        //画像を1ピクセルずつ処理します
        for (int x = 0; x < bm1.Width; x++)
        {
            for (int y = 0;  y < bm1.Height; y++)
            {
                Color c = bm1.GetPixel(x, y);    //ピクセルの色を取得します
                int rgb = c.ToArgb();            //RGB値に変換します
                //RGB値を取り出します
                int a = (rgb >> 24) & 0xFF;
                int r = (rgb >> 16) & 0xFF;
                int g = (rgb >> 8) & 0xFF;
                int b = (rgb >> 0) & 0xFF;
                switch(i)
                {
                    case 1:
                        r >>= 2; break;     //赤成分の値を小さくします
                    case 2:
                        g >>= 2; break;     //緑成分の値を小さくします
                    case 3:
                        b >>= 2; break;     //青成分の値を小さくします
                }
                //RGB値に変換します
                rgb = (a << 24) | (r << 16) | (g << 8) | (b << 0);
                
                c = Color.FromArgb(rgb);
                
                bm2.SetPixel(x, y, c);    //ピクセルの値を設定します
            }
        }
    }
    public void fm_Click(Object sender, EventArgs e)
    {
        i++;
        if (i >= 4)
            i = 0;
        convert();    //画像の変換を行います
        this.Invalidate();
    }
    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.DrawImage(bm2, 0, 0, 400, 300);
    }
}