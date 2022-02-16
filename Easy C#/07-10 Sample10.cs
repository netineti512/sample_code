//メニューを使う
using System;
using System.Windows.Forms;

class Sample10 : Form
{
    private Label lb;
    private MenuStrip ms;
    private ToolStripMenuItem[] mi = new ToolStripmenuItem[10];
    
    public static void Main()
    {
        Application.Run(new Sample10());
    }
    public Sample10()
    {
        this.Text = "サンプル";
        lb.Text = "いらっしゃいませ";
        lb.Dock = DockStyle.Bottom;
        
        //メインメニューを作成します
        ms = new MenuStrip();
        //メニュー項目を作成します
        mi[0] = new ToolStripMenuItem("メイン1");
        mi[1] = new ToolStripMenuItem("メイン2");
        mi[2] = new ToolStripMenuItem("サブ1");
        mi[3] = new ToolStripMenuItem("サブ2");
        mi[4] = new ToolStripMenuItem("乗用車");
        mi[5] = new ToolStripMenuItem("トラック");
        mi[6] = new ToolStripMenuItem("オープンカー");
        mi[7] = new ToolStripMenuItem("タクシー");
        mi[8] = new ToolStripMenuItem("スポーツカー");
        mi[9] = new ToolStripMenuItem("ミニカー");
        
        //ドロップダウン項目を設定します
        mi[0].DropDownitems.Add(mi[4]);
        mi[0].DropDownitems.Add(mi[5]);
        
        mi[1].DropDownitems.Add(mi[2]);
        mi[1].DropDownitems.Add(new ToolStripSeparator());   //セパレータです
        mi[1].DropDownitems.Add(mi[3]);
        mi[2].DropDownitems.Add(mi[6]);
        mi[2].DropDownitems.Add(mi[7]);
        mi[3].DropDownitems.Add(mi[8]);
        mi[3].DropDownitems.Add(mi[9]);
        
        //最上位のメニューを設定します
        ms.Items.Add(mi[0]);
        ms.Items.Add(mi[1]);
        
        //フォームのメニューを設定します
        this.MainMenuStrip = ms;
        
        //メニューが表示されます
        ms.Parent = this;
        lb.Parent = this;
        
        for (int i = 0; i < mi.Length; i++)
        {
            mi[i].Click += new EventHandler(mi_Click);
        }
    }
    public void mi_Click(Object sender, EventArgs e)
    {
        ToolStripMenu mi = (ToolStripMenuItem)sender;
        lb.Text = mi.Text + "ですね。";
    }
}