#関数をリストにする
def append():
    print("データを追加します。")
def update():
    print("データを変更します。")
def delete():
    print("データを削除します。")

list = [append, update, delete]     #関数をリストの要素にすることができます。

res = int(input("操作番号を入力して下さい。(0~2)\n"))

if 0 <= res and res < len(list):
    list[res]()     #リストの要素として関数を呼び出すことができます。


#操作番号を入力して下さい。(0~2)
#>>1
#データを変更します。