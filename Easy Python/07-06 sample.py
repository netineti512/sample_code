#戻り値をもつ関数
def sell(place, price, num):
    print(place, "支店で", num, "社に", price, "万円の販売が行われました。")
    
    tt = price * num
    return tt     #戻り値を返します。


total = sell("東京", 100, 5)     #関数を呼び出し、その戻り値を変数totalに代入します。

print("売上は", total, "万円でした。")   #戻り値の値を出力します。


#東京 支店で 5 社に 100 万円の販売が行われました。
#売上は 500 万円でした。