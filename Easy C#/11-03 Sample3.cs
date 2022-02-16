//並べ替えを行う
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

class Sample3 : Form
{
    private ListBox lbx;

    public void Main()
    {
        Application.Run(new Sample3());
    }
    public Sample3()
    {
        this.Text = "サンプル";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        var 車表 = new[] {
            new {番号 = 2, 名前 = "乗用車"},
            new {番号 = 3, 名前 = "オープンカー"},
            new {番号 = 4, 名前 = "トラック"},
        };

        //大きい順に並び変えます。
        IEnumerable qry = from K in 車表 where K.番号 <= 3 orderby K.番号 descending select new {K.名前, K.番号};

        foreach (var tmp in qry)
        {
            lbx.ItemsAdd(tmp);
        }
        lbx.Parent = this;
    }
}