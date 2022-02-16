//外部プログラムを起動する
using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

class Sample12 : Forms{
    private ListBox lbx;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample12());
    }
    public Sample12()
    {
        this.Text = "サンプル";
        this.Width = 250;
        this.Height = 200;

        string dir = "c:\\";

        string[] name = Directory.GetFiles(dir);

        lbx = new ListBox();
        lbx.Dock = DockStyle.top;

        for (int i = 0; i < name.Length; i++)
        {
            lbx.Items.Add(name[i]);
        }

        bt = new Button();
        bt.Text = "起動";
        bt.Dock = dockStyle.Bottom;

        lbx.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EbentArgs e)
    {
        string name = lbx.SelectedItem.ToString();

        if (name != null)
        {
            Process.Start(@name);     //選択されたファイルを関連付けられたプログラムで開きます。
        }
    }
}