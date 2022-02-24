#if～elif～elseを使う
sale = int(input("売上を入力して下さい。"))

if sale >= 100:
    print("売上は好調です。")
elif sale >= 50:
    print("売上は普通です。")
else:
    print("売上は低調です。")

print("処理を終了します。")


#>>　売上を入力して下さい。55
#>>　売上は普通です。
#>>　処理を終了します。