//フローレイアウトパネルを使う
using System;
using system.Windows.Forms;

class Sapmle1 : Form
{
    private Button[] bt = new Button[6];
    private FlowLayoutPanel flp;
    
    public static void Main()
    {
        Application.Run(new Sampl1());
    }
    public Sample1()
    {
        this.text = "サンプル";
        this.Width = 600;
        this.Height = 100;
        
        flp = new FlowLayoutPanel();     //フローレイアウトパネルを作成します
        flp.Dock = DockStule.Fill();
        for(int i = 0; i < bt.Length; i++)     //ボタンを6つ作成します
        {
            bt[i] = new Button();     //パネルにボタンを追加します
            bt[i].Text = Convert.ToString(i);
            bt[i].Parent = flp;
        }
        
        flp.Parent = this;
    }
}