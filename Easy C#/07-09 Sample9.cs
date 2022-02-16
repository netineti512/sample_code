//リストを利用する
using System;
using System.Windows.forms;

class Sample9 : Form
{
    private Label lb;
    private ListBox lbx;
    
    public static void Main()
    {
       public Sample9
       {
           //リストボックスのデータを用意する
           string[] str = {"乗用車", "トラック", "オープンカー", 
                           "タクシー", "スポーツカー", "ミニカー",
                           "自転車", "三輪車", "バイク",
                           "飛行機", "ヘリコプター", "ロケット"};
            
            this.Text = "サンプル";
            this.Width = 250;
            this.Height = 200;
            
            lb = new Label();
            lb.Text = "いらっしゃいませ";
            lb.dock = dockStyle.Top();
            
            //リストボックスを作成します
            lbx = new ListBox();
            
            for (int i = 0; i < str.Length; i++)
            {
                lbx.Items.Add(str[i]);
            }
            lbx.Top = lb.Bottom;
            
            lb.Parent = this;
            lbx.Parent = this;
            
            lbx.selectedIndexChanged += new EventHandler(lbx_SelectedIndexChanged);
       }
       public void lbx_SelectedChanged(Object sender, EventArgs e)
       {
           //項目を選択したときに、このメソッドが呼び出されて処理されます
           ListBox tmp = (ListBox)sender;
           
           lb.Text = tmp.Text + "を選びました。";
       }
    }
}