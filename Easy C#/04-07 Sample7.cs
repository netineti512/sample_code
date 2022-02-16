//文字列型の配列を作成する
using System.Windows.Forms;

class Sample7
{
    public static coid Main()
    {
        Form fm = new Forms();
        fm.Text = "サンプル";
        fm.Width = 250;
        fm.Height = 100;
        
        Label lb = new Label();
        lb.Width = fm.Width;
        lb.Height = fm.Height;
        
        string[] str = new string[3]{"鉛筆", "消しゴム", "定規"};
                                    //要素数3の配列を作成し、初期値を与えます
        
        foreach(string s in str)    //foreach文で配列を取り出すことができます
        {
            lb.Text += s + "\n";
        }
        
        lb.Parent = fm;
        
        Application.Run(fm);
    }
}