//文字列を表示する
using System.Windows.Forms;

class Sample3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.text = "ようこそC#へ！";
        
        Lavel lb = new Label();               //ラベルを作成します
        lb.Text = "C#をはじめましょう！";     //ラベルのタイトルを設定します
        lb.Parent = fm;                       //ラベルをフォームに乗せます
        
        Application.Run(fm);
    }
}