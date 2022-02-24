#セットを操作する
city = {"東京", "名古屋", "京都", "大阪", "福岡"}   #セットを作成します。
print("現在のデータは", city, "です。")

d = input("追加するデータを入力して下さい。\n")
if d in city:
    print(d, "は既に存在しています。")
else:
    city.add(d)     #セットの要素を追加する処理です。
    print(d, "を追加しました。")
print("現在のデータは", city, "です。")

d = input("削除するデータを入力して下さい。\n")
if d in city:
    city.remove(d)     #セットの要素を削除する処理です。
    print(d, "を削除しました。")
else:
    print(d, "は見つかりませんでした。")
print("現在のデータは", city, "です。")


#現在のデータは {'京都', '東京', '名古屋', '大阪', '福岡'} です。
#追加するデータを入力して下さい。
#>>近江
#近江 を追加しました。
#現在のデータは {'京都', '東京', '名古屋', '大阪', '福岡', '近江'} です。
#削除するデータを入力して下さい。
#>>京都
#京都 を削除しました。
#現在のデータは {'東京', '名古屋', '大阪', '福岡', '近江'} です。