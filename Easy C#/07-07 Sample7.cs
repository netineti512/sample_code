//ラジオボタンを使う
using System;
using System.windows.Forms;

class  Sample7 : Form
{
    private Label lb;
    private RadioButton rb1, rb2;
    private GroupBox gb;
    
    public static void Main()
    {
        Application.Run(new Sample7())
    }
    public Sample7()
    {
        this.Text = "サンプル";
        this.Width = 300;
        this.height = 200;
        
        lb = new Label();
        lb.text = "いらっしゃいませ";
        lb.Dock = DockStyle.Top;
        
        rb1 = new RadioButton();
        rb2 = new RadioButton();
        
        rb1.Text = "車";
        rb2.Text = "トラック";
        rb1.checked = true;
        
        rb1.Dock = DockStyle.Left;
        rb2.Dock = DockStyle.Right;
        
        gb = new GroupBox();     //グループボックスを作成します
        gb.Text = "種類";
        gb.Dock = DockStyle.Bottom;
        
        //グループボックスにラジオボタンを追加します
        rb1.Parent = gb;
        rb2.Parent = gb;
        
        lb.Parent = this;
        gb.Parent = this;
        
        rb1.Click += new EventHandler(rb_Click);
        rb2.Click += new EventHandler(rb_Click);
    }
    public void rb_Click(Object sender, EventArgs e)
    {
        RadioButton tmp = (RadioButton)sender;
        lb.Text = tmp.Text + "を選びました";
    }
}