//サーバーを作成する
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

class Sample5S
{
    public static string HOST = "localhost";
    public static int PORT = "10000;   //待機するボート番号を指定します。
    public static void Main()
    {
        IPHostEntry ih = Dns.GetHostEntry(HOST);

        TcpListener tl = new TcpListener(ih.AddressList[0], PORT);   //サーバソケットを作成します。
        tl.Start();

        Console.WriteLine("待機します。");
        while (true)
        {
            TcpClient tc = tl.AcceptTcpClient();   //接続を受け付けます。
            StreamWriter sw = new StreamWriter(tc.GetStrea());    //出力ストリームを作成します。
            sw.WriteLine("こちらはサーバーです。");   //文字列を書き出します。

            sw.Flush();
            sw.Close();
            tc.Close();   //接続をクローズします。
        }
    }
}