//チェックボックスを使う
using System;
using System.Windows.Forms;

class Sample6 : Form
{
    private Label lb;
    private CheckBox cb1, cb2;
    private FlowLayoutPanel flp;
    
    public static void Main()
    {
        Application.Run(new Sample6())
    }
    public Sample6()
    {
        this.Text = "サンプル";
        this.Width = 250;
        this.Height = 200;
        
        lb.new Label();
        lb.Text = "いらっしゃいませ";
        lb.Dock = DockStyle.top;
        
        cb1 = new CheckBox();
        cb2 = new CheckBox();
        
        cb1.Text = "車";
        cb2.Text = "トラック";
        
        flp = new FlowLayoutPanel();
        flp.Dock = DockStyle.Bottom;
        
        cb1.Parent = this;
        cb2.Parent = this;
        
        lb.Parent = this;
        flp.Parent = this;
        
        cb1.CheckedChanged += new EventHandler(cb_CheckedChanged);
        cb2.CheckedChanged += nes EventHandler(cb_CheckedChanged);
    }
    //チェックが変更されたときに呼び出されます
    public void cb_CheckedChanged(Obkect sender, EventArgs e)
    {
        CheckBox tmp = (CheckBox)sender;
        if (tmp.Checked == true)    //チェックマークを付けたときに
        {
            lb.Text = tmp.Text + "を選びました。";     //テキストを変更します
        }
        else if (tmp.Checked == false)    //チェックマークを外したときにも
        {
            lb.Text = tmp.Text + "をやめました";       //テキストを変更します
        }
    }
}