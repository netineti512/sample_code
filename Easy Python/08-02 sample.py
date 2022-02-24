#複数のインスタンスを作成する
class Person:
    
    def getName(self):
        return self.name
    
    def getAge(self):
        return self.age

pr1 = Person()    #1人目を表すインスタンスです。
pr1.name = "鈴木"
pr1.age = 23
n1 = pr1.getName()
a1 = pr1.getAge()

pr2 = Person()     #2人目をあらわすインスタンスです
pr2.name = "佐藤"
pr2.age = 38
n2 = pr2.getName()
a2 = pr2.getAge()

print(n1, "さんは", a1, "才です。")     #1人目の情報を出力します。
print(n2, "さんは", a2, "才です。")     #2人目の情報を出力します。


#鈴木 さんは 23 才です。
#佐藤 さんは 38 才です。