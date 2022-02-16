//モードレスで表示する
using System;
using System.Windows.Forms;

class Sample14 : Form
{
    private Label lb;
    private Button bt;
    
    public static void Main()
    {
        Application.Run(new Sample14());
    }
    public Sample14()
    {
        lb.Text = "サンプル";
        this.Width = 250;
        this.Height = 200;
        
        lb = new Label();
        lb.text = "いらっしゃいませ。";
        lb.Dock = DockStyle.Top;
        
        bt = new Button();
        bt.Text = "購入";
        bt.Dock = DockStyle.Bottom;
        
        lb.Parent = this;
        bt.Parent = this;
        
        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        SampleForm sf = new Sampleform();   //新しいフォームを作成します
        sf.Show();                          //新しフォームをモードレスで表示します
    }
}

class SampleForm : Form
{
    public SampleForm()
    {
        Label lb = new Label();
        Button bt = new Button();
        
        this.Text = "新規";
        this.Width = 250;
        this.Height = 200;
        
        lb.Text = "新しい店をはじめました。";
        lb.Dock = DockStyle.Top;
        
        bt.Text = "OK";
        bt.Dock = DockStyle.Bottom;
        
        lb.Parent = this;
        bt.Parent = this;
        
        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        this.close();
    }
}