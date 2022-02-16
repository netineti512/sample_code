//子フォームに表示する
using System;
using System.Windows.Forms;
using System.IO;

class Sample9 : Form
{
    private ChildForm[] cf;

    public static void main()
    {
        Application.run(new Sample9());
    }
    public Sample9()
    {
        this.Text = "サンプル";
        this.Width = 400;
        this.Height = 400;
        this.IsMdiContainer = true;

        string dir = "c:\\";   //指定したディレクトリについて、

        string[] fls ~ Directory.GetFiles(dir, "*xml");   //ファイルのリストを取得します。

        cf = new ChildForm[fls.Length];   //該当ファイル数の子フォームの配列を準備します

        for (int i = 0; i < fls.Length; i++)
        {
            cf[i] = new ChildForm(fls[i]);   //子フォームを作成します。
            cf[i].MdiParent = this;   //子フォームの親をこのフォームとします。
            cf[i].Show();      //子フォームを表示します
        }
    }
}

//子フォームの定義です。
class ChilForm : Form
{
    TextBox tb;

    public ChildForm(string name)
    {
        this.Text = name;

        tb = new TextBox();
        tb.Multiline = true;
        tb.Width = this.Width;
        tb.Height = this.Height;

        StreamReader sr = new StreamReader(name, System.text.Encoding.Default);
        tb.Text = sr.ReadToEnd();     //テキストボックスにファイル内容を読み込みます。
        sr.Close();

        tb.Parent = this;
    }
}