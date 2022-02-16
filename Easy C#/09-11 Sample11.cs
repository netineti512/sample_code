//検索を行う
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

class Sample11 : Form
{
    private Label lb;
    private RichTextBox rt;
    private TextBox tb;
    private Button bt;
    private TableLayoutPane tlp;

    public static void Main()
    {
        Application.Run(new Sampe11());
    }
    public Sample11()
    {
        this.Text = "サンプル";
        this.Width = 300;
        this.Height = 300;

        lb = new Label();
        lb.Dock = DockStyle.Fill;

        rt = new RichTextBox();    //色を変更できるリッチテキストボックスを使います。
        rt.Dock = DockStyle.Fill;

        tb = new TextBox();
        tb.Dock = DockStyle.Fill;

        bt = new Button();

        tlp = new TableLayoutPanel();
        tlp.ColumnCount = 2;
        tlp.RowCount = 3;
        tlp.Dock = DockStyle.Fill;

        lb.Text = "入力して下さい。";
        tlp.SetColumnSpan(lb, 2);

        rt.Multiline = true;
        rt.Height = 100;

        tlp.SetColumnSpan(rt, 2);

        bt.Text = "検索";
        tlp.SetColumnSpan(bt, 2);

        lb.Parent = tlp;
        rt.Parent = tlp;
        tb.Parent = tlp;
        bt.Parent = tlp;

        tlp.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        Regex rx = new Regex(tb.Text);   //検索文字列を指定します。
        Match m = null;
        ///対象文字列について検索を行い、
        //検索が成功する間、
        //次の検索を行います。
        for (m = rx.Match(rt.Text); m.Success; m = m.NextMatch());
        {
            rt.Select(m.Index, m.Length);
            rt.SelectionColor = Color.Red;   //検索が成功したら範囲を選択して赤色にします。
        }
    }
}