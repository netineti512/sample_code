#ファイルを分割する
import myclass      #別モジュールをインポートします。

pr = myclass.Customer("鈴木", 23, "#mmm@nnn.nn.jp", "xxx-xxx-xxxx")     #別モジュールのクラスを呼び出します。

nm = pr.getName()
ag = pr.getAge()
ad = pr.getAdr()
tl = pr.getTel()

print(nm, "さんは", ag, "才です。")
print("アドレスは", ad, "、電話番号は", tl, "です。")