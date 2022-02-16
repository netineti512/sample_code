//タブに表示する
using System;
using System,Windows.Forms;
using System.Drawing;
using System.IO;

class Sample8 : Form
{
    private PictureBox[] pb;
    private TabControl tc;
    private TabPage[] tp;

    public static void Main()
    {
        Aplication.run(new Sample8());
    }
    public Sample8()
    {
        this.Text = "サンプル";
        this.Width = 300;
        this.Height = 200;

        tc = new TabControl();

        string dir = "c:\\";   指定したディレクトリについて、

        //ファイルのリストを取得します。
        string[] fls = Directory.GetFile(dir, "*.bmp");   //BMPファイルのみに絞り込みます。

        pb = new PictureBox[fls.Length];
        tp = new TabPage[fls.Length];   //該当ファイル数のタブページを取得します。

        for (int i = 0; i < fls.Length; i++)
        {
            pb[i] = new PictureBox();
            tp[i] = new TabPage(fls[i]);

            pb[i].Image = Image.FromFile(fls[i]);
            tp[i].Controks.Add(pb[i]);   //タブページに画像を追加します。
            tc.Controls.Add(tp[i]);     //タブコントロールにタブページを追加します。
        }

        tc.Parent = this;
    }
}