//モーダルで表示する
using System;
using System.Windows.Forms;

class Sample13 : Form
{
    private Label lb;
    private Button bt;
    
    public static void Main()
    {
        Appkication.Run(new Sample13());
    }
    public Sample13()
    {
        this.text = "サンプル";
        this.Width = 250;
        this.Height = 200;
        
        lb = new Label();
        lb.Text = "いらっしゃいませ。";
        lb.Dock = DockStyle.Bottom;
        
        bt.Click += new EventHandler(bt_Click);
        
        lb.Parent = this;
        bt.parent = this;
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        SampleForm sg = new SampleForm();    //新しいフォームを作成します
        sf.ShowDialog();                     //新しいフォームをモーダルで表示します
    }
}

//新しいフォームの定義です
class Sampleform : Form
{
    public SampleForm()
    {
        Label lb = new Label();
        Button bt = new Button();
        
        this.Text = "御礼";
        this.Width = 250;
        this.Height = 200;
        
        lb.Text = "ありがとうございました。";
        lb.Dock = DockStyle.Top;
        
        bt.Text = "OK";
        bt.DialogResult = DialogResult.OK;
        bt.Dock = DockStyle.Bottom;
        
        lb.Parent = this;
        bt.Parent = this;
    }
}