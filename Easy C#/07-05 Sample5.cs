//ボタンを使う
using System;
using System.Windows.Forms;

class Sample5 : Form
{
    private Label lb;
    private Button bt;
    
    public static void Main()
    {
        Application.Run(new sample5());
    }
    public Sample5()
    {
        this.Text = "サンプル";
        this.Width = 250;
        this.height = 100;
        
        lb = new Label();
        lb.Text = "いらっしゃいませ";
        lb.dock = DockStyle.Top;
        
        bt = new Button();
        bt.text = "購入";
        bt.Dock = DockStyle.Bottom;
        
        bt.Click += new EventHandler(bt_Click);
        
        lb.PArent = this;
        bt.Parent = this;
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        lb.Text = "ご購入ありがとうございました。";
        bt.Enable = "false";         //ボタンを無効に設定します
    }
}