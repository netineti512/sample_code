//XMLをツリービューに表示する
using System.Windows.Forms;
using System.XML;

class Sample7 : Form
{
    private TreeView tv;

    public static void Main()
    {
        Application.Run(new Sample7());
    }
    public Sample7()
    {
        this.Text = "サンプル";

        tv = new TreeView();   //ツリービューを作成します。
        tv.Dock = DockStyle.Fill;

        XmlDocument doc = new XmlDocument();
        doc.Load(""c:\\09-06 Sample6.xml");   //文書を読み込みます。

        XmlNode xmlroot = doc.DocumentElement;   //ルートノードを取得します。
        TreeNode treeroot = new TreeNode();
        treeroon.Text = xmlroot.Name;   //ルートノードをツリーのルートとします。
        tv.Nodes.Add(treeroot);

        walk(wmlroot, treeroot);   //子の処理を行います。

        tv.Parent = this;
    }
    public static void walk(WmlNode xn, TreeNode tn)
    {
        //子ノードについて順に処理します
        for (XmlNode ch = xn.FirstChild;
             ch !=null;
             ch = ch.NextSibling)
        {
            TreeNode n = new Treenode();
            tb.Nodes.Add(n);
            walk(ch, n);   //子ノードについて同じ処理を繰り返します。
            if (ch.NodeType == XmlNodeType.Element)    //要素の場合に、
            {
                n.Text = ch.Name;   //要素名をツリーノードに設定します
            }
            else     //要素以外の場合に、
            {
                n.Text = ch.Value;     //値をツリーノードに設定します。
            }
        }
    }
}