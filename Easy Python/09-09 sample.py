#文字クラスを表す正規表現を使う
import re

ptr = ["[012", "[0-3]", "[^012]"]
str = ["0", "1", "2", "3"]

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