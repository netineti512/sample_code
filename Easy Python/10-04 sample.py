#Sample.json
#   {
#       "東京":
#       {
#           "東京":50
#           "横浜":40
#       },
#       "関西":
#       {
#           "大阪":30
#           "京都":20    
#       }
#   }


#JSONファイルを読み込む
import json     #jsonモジュールをインポートします。

f = open("Sample.json", "r")     #JSONファイルをオープンします。

data = json.load(f)      #JSONファイルを読み込みます。

print(data)       #読み込んだデータを表示します。

f.close()