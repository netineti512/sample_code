#正規表現で置換する
import re

ptr = "\.(csv|html|py)$"     #正規表現によるパターンです。
str = ["Sample.csv", "Sample.exe", "test.py", "index.html"]

pattern = re.compile(ptr)
for valuestr in str:
    res = pattern.sub(".txt", valuestr)   #パターンにマッチした文字列の置換を行います。
    msg = "(変換前)" + valuestr + "(変換後)" + res
    print(msg)


#(変換前)Sample.csv(変換後)Sample.txt
#(変換前)Sample.exe(変換後)Sample.exe
#(変換前)test.py(変換後)test.txt
#(変換前)index.html(変換後)index.txt