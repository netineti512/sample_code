#sample.csv
#東京,鉛筆,25
#東京,消しゴム,30
#名古屋,ノート,56
#大阪,定規,100
#福岡,ノート,73

#CSVファイルを読み込む
import csv     #csvモジュールをインポートします。

f = open("Sample.csv", "r")     #csvファイルを読み込みます。

rd = csv.reader(f)       #リーダを取得します。

for row in rd:     #1行取り出し、
    for col in row:     #そのなかの列項目を1つ取り出し、
        print(col, end=",")    #表示します。
    print()
f.close()