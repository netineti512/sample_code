#文字クラスを表す正規表現を使う
import re

#グループ化と選択を行うパターンを使います。
ptr = ["(TXT)+", "TXT|XTX"]
str = ["TX", "TXT", "XTX", "TXTXT"]

for valueptr in ptr:
    print("------------")
    pattern = re.compile(valueptr)
    for valuestr in str:
        res = pattern.search(valuestr)     #パターンマッチングを行います。
        if res is not None:
            m = "○"
        else:
            m = "×"
        msg = "(パターン)" + valueptr + "(文字列)" + valuestr + "(マッチ)" + m
        print(msg)


#------------
#(パターン)(TXT)+(文字列)TX(マッチ)×
#(パターン)(TXT)+(文字列)TXT(マッチ)○
#(パターン)(TXT)+(文字列)XTX(マッチ)×
#(パターン)(TXT)+(文字列)TXTXT(マッチ)○
#------------
#(パターン)TXT|XTX(文字列)TX(マッチ)×
#(パターン)TXT|XTX(文字列)TXT(マッチ)○
#(パターン)TXT|XTX(文字列)XTX(マッチ)○
#(パターン)TXT|XTX(文字列)TXTXT(マッチ)○