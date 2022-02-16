//ラベルにテキストを設定する
using System.Windows.Forms;
using System.Drawing;

class Sample3 : Form
{
    private Label[] lb = new Label[3];
    private TableLayoutPanel tlp;
    
    public static void Main()
    {
        Application.Run(new.Sample3());
    }
    public Sample3()
    {
        this.Text = "サンプル";
        this.Width = 250;
        this.Height = 200;
        
        tlp = new TableLayoutPanel();
        tlp.Dock = DockStyle.Fill;
        
        tlp.ColumnCount = 1;
        tlp.Rowcount = 3;
        
        for (int i = 0; i < lb.Length; i++)
        {
            lb[i] = new Label();
            lb[i].Text = i + "号車です。";
        }
        
        //前景色を設定します
        lb[0].ForeColor = Color.Black;
        lb[1].ForeColor = Color.Black;
        lb[2].ForeColor = Color.Black;
        
        //背景色を設定します
        lb[0].BackColor = Color.White;
        lb[1].BackColor = Color.Gray;
        lb[2].BackColor = Color.White;
        
        //位置揃えを設定します
        lb[0].TextAlign = ContentAlignment.TopLeft;
        lb[1].TextAlign = ContentAlignment.MiddleCenter;
        lb[2].TextAlign = ContentAlignment.BottomRight;
        
        //境界線を設定します
        lb[0].BorderStyle = BorderStyle.None;
        lb[1].BorderStyle = BorderStyle.FixedSingle;
        lb[0].BorderStyle = BorderStyle.fixed3D;
        
        for (int i = 0; i < lb.Length; i++)
        {
            lb[i].Parent = tlp;
        }
        
        tlp.Parent = this;
    }
}