//Webページを表示する
using System;
using System.Windows.Forms;
using System.Net;

class Sample3 : Form
{
    private TextNox tb;
    private WebBrowser wb;
    private ToolStrip ts;
    private ToolStripButton[] tsb = new ToolStripButton[2];

    [STAThread]
    public static void Main()
    {
        Application.Run(new Sample3());
    }
    public Sample3()
    {
        this.Text = "サンプル";
        this.width = 600;
        this.Height = 400;

        tb = new TextBox();
        tb.Text = "http://";
        tb.Dock = DockStyle.Top;

        wb = new WebBrowser;   //Webブラウザコントロールを作成します。
        wb.dock = DockStyle.Fill;

        ts = new ToolStrip();
        ts.Dock = DockStyle.Top;

        for (int i = 0; i < tsb.Length; i++)
        {
            tsb[i] = new ToolStripButton();
        }

        tsb[0].Text = "Go";
        tsb[1].Text = "←";

        tsb[0].ToolTipText = "移動";
        tsb[1].ToolTipText = "戻る";

        tsb[1].Enabled = false;

        for (int i = 0; i < tsb.Length; i++)
        {
            ts.Items.Add(tsb[i]);
        }

        tb.Parent = this;
        wb.Parent = this;
        ts.Parent = this;

        for (int i = 0; i < tsb.Length; i++)
        {
            tsb[i].Click += new EventHandler(bt_Click);
        }
        
        wb.CanGoBackChanged += new EventHandler(wb_CanGoBackChanged);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        if (sender == tsb[0])
        {
            try
            {
                Uri uri = new Uri(tb.Text);
                wb.Url = uri;   //指定URLのページを開きます。
            }
            catch
            {
                MessageBox.Show("URLを入力して下さい。");
            }
        }
        else if (sender == tsb[1])
        {
            wb.Goback();   //「戻る」処理を行います。
        }
    }
    public voidwb_CanGobackChanged(object sender, EventArgs e)   //「戻る」履歴が変更されたら、
    {
        tsb[1].Enabled = wb.CanGoBack;   //ボタンの有効・無効を「戻る」可否とあわせます。
    }
}