#行頭・行末をあらわす正規表現を使う
import re

#「^」と「$」を使ったパターンを用意します。
ptr = ["TXT", "^TXT", "TXT$", "^TXT$"]
str = ["TXT", "TXTT", "TXTTT", "TTXT"]

for valueptr in ptr:
    print("---------")
    pattern = re.compile(valueptr)
    for valuestr in str:
        res = pattern.search(valuestr)     #パターンマッチングを行います。
        if res is not None:
            m = "○"
        else:
            m = "×"
        msg = "(パターン)" + valueptr + "(文字列)" + valuestr + "(マッチ)" + m
        print(msg)


#---------
#(パターン)TXT(文字列)TXT(マッチ)○
#(パターン)TXT(文字列)TXTT(マッチ)○
#(パターン)TXT(文字列)TXTTT(マッチ)○
#(パターン)TXT(文字列)TTXT(マッチ)○
#---------
#(パターン)^TXT(文字列)TXT(マッチ)○
#(パターン)^TXT(文字列)TXTT(マッチ)○
#(パターン)^TXT(文字列)TXTTT(マッチ)○
#(パターン)^TXT(文字列)TTXT(マッチ)×
#---------
#(パターン)TXT$(文字列)TXT(マッチ)○
#(パターン)TXT$(文字列)TXTT(マッチ)×
#(パターン)TXT$(文字列)TXTTT(マッチ)×
#(パターン)TXT$(文字列)TTXT(マッチ)○
#---------
#(パターン)^TXT$(文字列)TXT(マッチ)○
#(パターン)^TXT$(文字列)TXTT(マッチ)×
#(パターン)^TXT$(文字列)TXTTT(マッチ)×
#(パターン)^TXT$(文字列)TTXT(マッチ)×