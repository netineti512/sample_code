//2次元配列を使う
using System.Windows.Forms;

 class Sample8
 {
     public static void Main()
     {
         Form fm = new Form();
         fm.Text = "サンプル";
         fm.Width = 250;
         fm.Height = 100;
         
         string[][] str = new string[4][]{     //ジャグ配列を作成します
             new string[] {"東京", "Tokyo", "とうきょう", "トウキョウ"},
             new string[] {"大阪", "Osaka", "おおさか"},
             new string[] {"名古屋", "Nagoya", "なごや", "ナゴヤ"},
             new string[] {"福岡", "Fukuoka", "ふくおか"}
         };                                     //各配列要素の長さは決まっていません
         
         Label lb = new Label();
         lb.Width = fm.Width;
         lb.Height = fm.Height;
         
         string tmp = "";
         
         for (int i = 0; i < str.Length; i++)      //i個の配列にアクセスします
         {
             tmp += "(" ;
             for (int j = 0; j < str[j].Length; j++)   //j個の配列要素にアクセスします
             {
                 tmp += str[i][j];                  //i番目の配列要素がさす配列のj番目の要素を利用します
                 tmp += ",";
             }
             tmp += ")\n";
         }
         
         lb.Text = tmp;
         lb.Parent = fm;
         
         Application.Run(fm);
     }
 }