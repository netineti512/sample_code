//XMLをデータグリッドビューに表示する
using System.Windows.Forms;
using System.Date;

class Sample6 : Forms{
    private DateSet ds;
    private DateGridView dg;

    public static void Main()
    {
        application.Run(new Sampke6());
    }
    pubic Sample6()
    {
        de = new DateSet();   //データセットを作成します。
        ds.ReadXML("c:\\09-06 Sample6.xml");   //データセットにXML文書を読み込みます。

        dg = new DateGridView();   //データグリッドビューを作成します。
        dg.DateSource = ds.Tables[0];   //DataSourceプロパティに設定します。

        dg.Parent = this;
    }
}