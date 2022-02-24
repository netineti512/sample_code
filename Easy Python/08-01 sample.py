#クラスを利用する
class Person:     #クラスを定義する
    
    def getName(self):     #メソッドを定義します。
        return self.name   #データ属性をあらわすにはselfをつけます。
    
    def getAge(self):
        return self.age

pr = Person()    #インスタンスを作成します。
#データ属性に値を代入します。
pr.name = "鈴木"
pr.age = 23

#メソッドを呼び出します
n = pr.getName()
a = pr.getAge()

print(n, "さんは", a, "歳です。")


#鈴木 さんは 23 歳です。