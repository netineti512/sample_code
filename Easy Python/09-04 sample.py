#文字列を検索する
str = input("文字列を入力して下さい。\n")
key = input("検索する文字列を入力して下さい。\n")

res = str.find(key)     #検索を行います。

if res != -1:
    print(str, "の", res, "の位置に", key, "が見つかりました。")
else:
    print(str, "の中に", key, "が見つかりませんでした。")


#文字列を入力して下さい。
#>>asdfg
#検索する文字列を入力して下さい。
#>>asd
#asdfg の 0 の位置に asd が見つかりました。