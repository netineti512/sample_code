#継承とオーバーロード
class Person:   #基底クラスの定義です。
    def __init__(self, name, age):
        self.name = name
        self.age = age
    
    def getName(self):
        return self.name
    
    def getAge(self):
        return self.age

class Customer(Person):    #派生クラスの定義です
    def __init__(self, nm, ag, ad, tl):
        super().__init__(nm, ag)    #基底クラスのデータ属性を初期化するために、基底クラスのコンストラクタを呼び出しています。
        
        #追加するデータ属性です。
        self.adr = ad
        self.tel = tl
    
    def getName(self):     #基底クラスのメソッドを上書きすることもできます。
        self.name = "顧客：" + self.name
        return self.name
    
    #追加するメソッドです。
    def getAdr(self):
        return self.adr
    
    #追加するメソッドです。
    def getTel(self):
        return self.tel

pr = Customer("鈴木", 23, "#mmm@nnn.nn.jp", "xxx-xxx-xxxx")

nm = pr.getName()
ag = pr.getAge()
ad = pr.getAdr()
tl = pr.getTel()

print(nm, "さんは", ag, "才です。")
print("アドレスは", ad, "、電話番号は", tl, "です。")


#顧客：鈴木 さんは 23 才です。
#アドレスは #mmm@nnn.nn.jp 、電話番号は xxx-xxx-xxxx です。