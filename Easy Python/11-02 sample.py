#条件を付けて絞り込む
import sqlite3

conn = sqlite3.connect("pdb.db")

c = conn.cursor()

itr = c.execute("SELECT * FROM product WHERE price>=200")      #条件を付けて取り出します。

for row in itr:
    print(row)

conn.close()