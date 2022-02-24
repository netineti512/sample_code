#ディクショナリの情報を知る
sale = {"東京":80, "名古屋":60, "京都":22, "大阪":50, "福岡":75}
print("現在のデータは", sale, "です。")

print("キーを表示します。")
for k in sale.keys():
    print(k, end="\t")   #キーを1つずつ取得します。
print()

print("値を表示します。")
for v in sale.values():   #値を1つずつ取得します。
    print(v, end="\t")
print()

print("キーと値を表示します。")
for i in sale.items():   #キーと値の組を1つずつ取得します。
    print(i, end="")
print()


#現在のデータは {'東京': 80, '名古屋': 60, '京都': 22, '大阪': 50, '福岡': 75} です。
#キーを表示します。
#東京    名古屋  京都    大阪    福岡
#値を表示します。
#80      60      22      50      75
#キーと値を表示します。
#('東京', 80)('名古屋', 60)('京都', 22)('大阪', 50)('福岡', 75) 