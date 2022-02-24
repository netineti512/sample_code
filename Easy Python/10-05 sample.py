#例外処理を行う
try:
    f = open("Sample.txt", "r")     #ファイルをオープンできない例外が発生した場合に、

except FileNotFoundError:     #このexceptブロックを処理します。
    print("ファイルをオープンできませんでした。")

else:
    lines = f.readlines()      #例外が発生しなかった場合はelseブロックを処理します。
    for line in lines:
        print(line, end="")
    f.close()

finally:      #例外の発声に関わらすfinallyブロックが処理されます。
    print("処理を終了します。")


#ファイルをオープンできませんでした。
#処理を終了します。