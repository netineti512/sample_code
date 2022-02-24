#テキストファイルを読み込む
f = open("Sample.txt", "r")     #ファイルを読み込みモードでオープンします。

lines = f.readlines()           #すべての行を読み出します。

for line in lines:        #1行ずつ繰り返し取り出して、
    print(line, end="")   #表示します。

f.close()