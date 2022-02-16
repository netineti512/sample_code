//メッセージボックスを変更する
using System;
using System.Windows.Forms;

class Sample11 : Form
{
    private Label lb;
    private Button bt;
    
    public static void Main()
    {
        this.Text = "サンプル";
        this.Width = 250;
        this.Height = 200;
        
        lb = new Label();
        lb.Text = "いらっしゃいませ";
        lb.Dock = DockStyle.Top;
        
        bt = new Button();
        bt.Text = "購入";
        bt.Dock = DockStyle.Bottom;
        bt.Click += new EventHandler(bt_Click);
        
        lb.Parent = this;
        bt.Parent = this;
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        public void bt_Click(Object sender, EventArgs e)
        //ボタンを指定します
        //アイコンを指定します
        DialogResult dr = MessageBox.Show("本当に購入しますか？", "確認", MessageButtons.YesNo, MessageBoxIcon.Question);
        
        if (dr == DialogResult.Yes)
        {
            MessageBox.Show("ご購入ありがとうございました", "購入", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}