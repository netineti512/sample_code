#日時を扱う
import datetime     #datetimeモジュールをインポートします。

dt = datetime.datetime.now()     #現在の日時を取得します。
print("現在は", dt, "です。")
#日時をあらわすデータ属性を取得します。
print("年:", dt.year)
print("月:", dt.month)
print("日:", dt.day)

dt = dt + datetime.timedelta(days=1)    #日時の加算を行うことができます。
print("1日後は", dt, "です。")


#現在は 2022-02-24 15:38:11.967711 です。
#年: 2022
#月: 2
#日: 24
#1日後は 2022-02-25 15:38:11.967711 です。