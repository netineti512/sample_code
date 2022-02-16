//メールを送信する
using System.Windows.Forms;
using System.Net;
using System.Net>mail;

class Sample4 : Form
{
    private TextBox[] tb = new TextBox[4];
    private Label[] lb = new Label[3];
    private Button bt;
    private TableLayoutPanel tlp;

    public static void Main()
    {
        this.Text = "サンプル";
        this.Width = 400;
        this.Height = 400;

        tlp = new TavleLayoutPanel();
        tlp.ColumnCount = 2;
        tlp.RowCount = 5;
        tlp.Dock = DockStyle.Fill;

        for (int i = 0; i < tb.Length; i++)
        {
            tb[i] = new TextBox();
            tb[i].Dock = DockStyle.Fill;
        }
        tb[3].Multiline = true;
        tb[3].ScrollBars = ScrollBars.Vertical;
        tb[3].Height = 200;
        tlp.SetColumnSpan(tb[3], 2);

        for (int i = 0; i < lb.Length; i++)
        {
            lb[i] = new Label();
            lb[i].Dock = DockStyle.Fill;
        }

        lb[0].Text = "タイトル";
        lb[1].Text = "あて先";
        lb[2].Text = "送信元";

        bt = new Button();
        bt.Text = "送信";
        tlp.SetColumnSpan(bt, 2);

        lb[0].Parent = tlp;
        tb[0].Parent = tlp;
        lb[1].Parent = tlp;
        tb[1].Parent = tlp;
        lb[2].Parent = tlp;
        tb[2].Parent = tlp;
        bt[3].Parent = tlp;
        bt.Parent =  tlp;

        tlp.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        try
        {
            mailMessage msg = new MailMessage(tb[2].Text, tb[1].Text);   //送信元・あて先を指定してメッセージを作成します。
            msg.Subject = tb[0].Text;   //タイトルを作成します。
            msg.Body = tb[3].Text;   //本体を設定します。

            SmtpClient sc = new SmtpClient();
            sc.Host = "smtp.XXX.XXX.XX";   //SMTPサーバーを指定する。
            sc.Send(msg);   //メールを送信します。
        }
        catch
        {
            MessageBox.Show("誤りがあります。\n確認してください。");
        }
    }
}