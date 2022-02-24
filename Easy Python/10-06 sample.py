#ディレクトリ情報を調べる
import os

curdir = os.listdir(".")      #ディレクトリのリストを取得します。

for name in curdir:      #リストから1つディレクトリ・ファイルを取得して。
    print(name)          #その名前を表示します。