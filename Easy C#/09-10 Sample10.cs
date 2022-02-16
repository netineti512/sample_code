//置換を行う
using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

class Sample10 : Form
{
    private Label[] lv = new Label[3];
    private TextBox[] tb = new TextBox[3];
    private Button bt;
    pribate TableLayoutPane tlp;

    public static void Main()
    {
        Application.Run(new Sample10());
    }
    public Sample10()
    {
        this.Text = "サンプル";
        this.Width = 300;
        this.Height = 300;

        for (int i = 0; i < lb.Length; i++)
        {
            lb[i] = new Label();
            lb[i].Dock = DockStyle.Fill;
        }
        for (int i = 0; i < tb.Length; i++)
        {
            tb[i] = new TextBox();
            tb[i].dock = DockStyle.Fill;
        }

        bt = new Button();

        tlp = new TableLayoutPanel();
        tlp.ColumnCount = 2;
        tlp.RowCount = 5;
        tlp.Dock = DockStyle.Fill;

        lb[0].Text = "入力して下さい。";
        tlp.SetColumnSpan(tb[0], 2);

        lb[1].Text = "置換前";
        lb[2].Text = "置換後";
        bt.Text = "置換";
        tlp.SetColumnSpan(tb[0], 2);

        lb[0].Parent = tlp;
        tb[0].Parent = tlp;
        lb[1].Parent = tlp;
        tb[1].Parent = tlp;
        lb[2].Parent = tlp;
        tb[2].Parent = tlp;
        bt.Parent = tlp;

        tlp.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        Regex rx = new Regex(tb[1].Text);   //置換元文字列からパターンを得ます。
        tb[0].Text = rx.Replace(tb[0].text, tb[2].Text);   //置換先文字列に置換します。
    }
}