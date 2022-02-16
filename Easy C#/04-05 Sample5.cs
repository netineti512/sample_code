//for文を使う
using System.Windows.Forms;

Class Sample5
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 300;
        fm.Height = 150;
        
        Label lb = new Label();
        lb.Width = fm.Width;
        lb.Height = fm.Height;
        
        for (int i = 0; i < 5; i++){
            lb.Text += i + "号車を表示します。\n";     //変数を使って表示します
        }
        
        pb.Parent = gm;
        
        Application.Run(fm);
    }
}