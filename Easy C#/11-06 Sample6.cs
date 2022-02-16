//検索した要素の値を表示する
using System;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Collectons;

class Sample6 : Form
{
    private LiatBox lbx;

    public static void Main()
    {
        Application.Run(new Sample6());
    }
    public Sample6()
    {
        this.Text = "サンプル";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dok = DockStyle.Fill;

        XDocument doc = XDocument.Load("c:\\Sample.xml");

        //直下の要素の値を取り出します。
        IEnumerable qry = from K in doc.Descendants("car") where (int)K.Attribute("id") >= 1005 select K.Element("name").Value;

        foreach (var tmp in qry)
        {
            lbx.Items.Add(tmp)
        }
        lbx.Parent = this;
    }
}