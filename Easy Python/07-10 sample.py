#デコレータを使う
def deco(func):     #外側の関数でもとの関数を引数として受け取り、
    def wrapper(x):
        wx = "---" + x + "---"
        return func(wx)     #内側の関数で処理を行い、元の関数も処理します。
    return wrapper          #外側の関数が内側の関数を戻り値として返しています。

@deco     #デコレータとして指定して、
def printmsg(x):
    print(x, "を入力しました。")     #関数に機能を追加できます。

str = input("メッセージを入力して下さい。\n")

printmsg(str)


#メッセージを入力して下さい。
#>>頭
#---頭--- を入力しました。