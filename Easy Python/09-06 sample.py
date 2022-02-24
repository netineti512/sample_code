#正規表現を使う
import re     #正規表現のreモジュールをインポートする。

ptr = ["Apple", "GoodBye", "Thankyou"]    #パターン文字列を用意します。
str = ["Hello", "GoodBye", "Thankyou"]    #検索対象文字列を用意します。

for valueptr in ptr:
    print("--------")
    pattern = re.compile(valueptr)     #パターン文字列を用意します。
    for valuestr in str:
        res = pattern.search(valuestr)  #検索(パターンマッチング)を行います。
        if res is not None:
            m = "○"
        else:
            m = "×"
        msg = "(パターン)" + valueptr + "(文字列)" + valuestr + "(マッチ)" + m
        print(msg)


#--------
#(パターン)Apple(文字列)Hello(マッチ)×
#(パターン)Apple(文字列)GoodBye(マッチ)×
#(パターン)Apple(文字列)Thankyou(マッチ)×
#--------
#(パターン)GoodBye(文字列)Hello(マッチ)×
#(パターン)GoodBye(文字列)GoodBye(マッチ)○
#(パターン)GoodBye(文字列)Thankyou(マッチ)×
#--------
#(パターン)Thankyou(文字列)Hello(マッチ)×
#(パターン)Thankyou(文字列)GoodBye(マッチ)×
#(パターン)Thankyou(文字列)Thankyou(マッチ)○