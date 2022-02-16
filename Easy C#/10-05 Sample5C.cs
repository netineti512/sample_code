//クライアントを作成する
using System;
using System.IO;
using System.Net;
using System.Net.Socket;
using System.Windows.Forms;

class Sample5C : Form
{
    public static string HOST = "localhost";     //ホスト名を指定します。
    public static int PORT = 10000;   //ポート番号を指定します。

    TextBox tb;
    Button bt;

    public static void Main()
    {
        Application.Run(new Sample5C());
    }
    public Sample5C()
    {
        this.Text = "サンプル";
        this.Width = 300;
        this.Height = 300;

        tb = new TextBox();

        tb.Multiline = true;
        tb.Scrollbars = ScrollBars.Vertical;
        tb.Height = 150;
        tb.Dock = DockStyle.Bottom;

        tb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)    //サーバに接続します。
    {
        TcpClient tc = new TcpClient(HOST, PORT);

        StreamReader sr = new StreamReader(tc.GetStream());   //入力ストリームを作成します。
        String str = sr.ReadLine();   //文字列を読み込みます。

        sr.Close();
        tc.Close();     //接続をクローズします。
    }
}