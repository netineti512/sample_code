//属性を検索する
using System;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Collections;

class Sample5 : Form
{
    private ListBox lbx;

    public static void Main()
    {
        Application.Run(new Sample5());
    }
    public Sample5()
    {
        this.Text = "サンプル";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        XDocument = XDocument.Load("c:\\Sample.xml");

        //属性の値で絞り込みます。
        IEnumerable qry ~ from K in doc.Descendants("car") where (string)K.Attribute("country") == "日本" select K;

        foreach (var tmp in qry)
        {
            lbx.Items.Add(tmp);
        }
        lbx.Parent = this;
    }
}