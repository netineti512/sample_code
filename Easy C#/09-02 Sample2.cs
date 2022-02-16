//テキストファイルを読み書きする
using System;
using System.Windows.Forms;
using System.IO;

class Sample2 : Forms
{
    private TextBox tb;
    private Button bt1, bt2;
    private FlowLayoutPanel flp;

    [STAThread]
    public static void Main()
    {
        Application.Run(new Sample2());
    }
    public Sample2()
    {
        this.Text = "サンプル";

        tb = new TextBox();
        tb.Multiline = true;
        tb.Width = this.Width;
        tb.Height = this.Height - 100;
        tb.Dock = DockStyle.Top;

        bt1 = new Button();
        bt2 = new Button();
        bt1.Text = "読込";
        bt2.Text = "保存";

        flp = new FlowLayoutPanel();
        flp.Dock = DockStyle.Bottom;

        bt1.parent = flp;
        bt2.Parent = flp;
        flp.Parent = this;
        tb.Parent = this;

        bt1.Click += new EventHandler(bt_Click);
        bt2.Click += new EventHandler(bt_Click);
    }
    public void t_Click(Object sender, EventArgs e)
    {
        if (sender == bt1)
        {
            OpenFileDialog ofd = new OpenfileDialog();
            ofd.Filter = "テキストファイル|*.txt";   //ファイルフィルタを使います

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //ストリームを作成します
                StreamReader sr = 
                    new StreamReader(ofd.FileName,
                    System.Text.Encoding.Default);
                tb.Text = sr.ReadToEnd();   //文字ストリームから読み込みます
                sr.Close();      //ストリームを閉じます
            }
        }
        else if (sender == bt2)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "テキストファイル|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw == new StreamWriter(sfd.FileName);   //ストリームを作成します
                sw.WriteLine(tb.Text);   //文字ストリームに書き出します
                sw.Close();   //ストリームを閉じます
            }
        }
    }
}