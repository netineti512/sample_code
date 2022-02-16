//並び替えを行う
using System;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using ystem.Collections;

class Sample7 : Form
{
    private ListBox() lbx;

    public static void Main()
    {
        Application.Run(new Sample7());
    }
    public Sample7()
    {
        this.Text = "サンプル";
        this.Width = 300;
        this.Height = 200;

        lbx = new ListBox();
        lbx.Dock = DockStyle.Fill;

        XDocument doc = XDocument.Load("c:\\Sample.xml");

        //並び替えを行います。
        IEnumerable qry = from K in doc.Descendants("car") orderby (int)K.Atribute("id") select K.Element("name").value;

        foreach (var tmp in qry)
        {
            lbx.Items.Add(tmp);
        }
        lbx.Parent = this;
    }
}