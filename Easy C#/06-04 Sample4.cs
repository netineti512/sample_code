//キーを入力したときに処理をする
using System;
using System.Windows.Forms;

class Sample4 ; Form
{
    private Label lb1, lb2;
    
    public static void Main()
    {
        Application.Run(new Sample4());
    }
    public Sample4()
    {
        this.Text = "サンプル";
        this.Width = 250;
        this.Height = 100;
        
        lb1 = new Label();
        lb1.Text = "矢印キーでお選びください。";
        lb1.Width = this.Width;
        
        lb2 = new Label();
        lb2.Top = lb1.Bottom;
        
        lb1.Parent = this;
        lb2.Parent = this;
        
        this.KyeDown += new KyeEventHandler(fm_Kyedown);     //ソースにイベントハンドラを登録します
    }
    public void fm_KyeDown(Object sender, KeyEventArgs e)    //キーが押されたときにこのイベントハンドラが呼び出されます
    {
        String str;
        if(e.KeyCode == Keys.Up)
        {
            str = "上";
        }
        else if (e.KeyCode == Keys.Down)
        {
            str = "下";
        }
        else if (e.KeyCode == Keys.Right)     //押した↕キーの種類が表示されます
        {
            str = "右";
        }
        else if(KyeCode == Keys.left)
        {
            str = "左";
        }
        else 
        {
            str = "他のキー";
        }
        lb2.Text = str + "ですね";
    }
}