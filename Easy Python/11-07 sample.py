#HTMLを解析する
import urllib.request     #html.parserモジュールのHTML Parserクラスをインポートします。
from html.parser import HTMLParser

class SampleHTMLParser(HTMLParser):     #HTMLParserクラスを基底クラスとした派生クラスを定義します。
    def __init__(self):                 #コンストラクタを定義しています。
        self.title = False
    
    def handle_starttag(self, tag, attrs):    #HTMLの開始タグを解析するメソッドを定義します。
        if tag == "title":
            self.title = True
    
    def handle_data(self, data):      #HTML中のデータ尾取得するメソッドを定義します。
        if self.title is True:
            print("タイトル：", data)
            self.title = False

page= urllib.request.urlopen("https://www.python.org/")

html = page.read()
str = html.decode()

p = SampleHTMLParser()      #定義したクラスのインスタンスを作成し、
p.feed(str)                 #読み込んだページを解析します。

p.close()