#ファイル情報を調べる
import os
import os.path      #os.pathモジュールをインポートします。

curdir = os.listdir(".")

for name in curdir:
    print(os.path.abspath(name), end=",")     #絶対パス名を表示します。
    
    if (os.path.isfile(name)):      #ファイルであるかを調べ、
        print("ファイルです。")
    else:
        print("ディレクトリです。")
print()