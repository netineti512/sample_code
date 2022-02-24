#表を表示する
import sqlite3      #データベースを利用するためのモジュールをインポートします。

conn = sqlite3.connect("pbd.db")     #データベースに接続します。

c = conn.cursor()      #カーソルを取得します。

c.execute("DROP TABLE IF EXISTS product")

#表を作成します。
c.execute("CREATE TABLE product(name CHAR(20), price INT)")
#データを追加します。
c.execute("INSERT INTO product VALUES('鉛筆', 80)")
c.execute("INSERT INTO product VALUES('消しゴム', 50)")
c.execute("INSERT INTO product VALUES('定規', 200)")
c.execute("INSERT INTO product VALUES('コンパス', 300)")
c.execute("INSERT INTO product VALUES('ボールペン', 100)")

conn.commit()      #コミットします。

itr = c.execute("SELECT * FROM product")      #表のデータベースを全て取りだします。

#取り出したデータを取得します。
for row in itr:
    print(row)

conn.close()      #データベースをクローズします。


#('鉛筆', 80)
#('消しゴム', 50)
#('定規', 200)
#('コンパス', 300)
#('ボールペン', 100)