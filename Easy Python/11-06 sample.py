#URLをオープンする
import urllib.request      #urllib.requestモジュールを使用します。

page = urllib.request.urlopen("https://www.python.org/")      #URLを指定してオープンして、

html = page.read()    #読込を行います。
str = html.decode()   #文字列に変換して、

print(str)