#コンストラクタ
from ipaddress import NetmaskValueError


class Person:
    
    def __init__(self, name, age):     #インスタンスを作成する際に呼び出されます。
        self.name = name
        self.age = age
        
    def getName(self):
        return self.name
        
    def getAge(self):
        return self.age

pr = Person("鈴木", 23)     #インスタンスを作成する

n = pr.getName()
a = pr.getAge()

print(n, "さんは", a, "才です。")


#鈴木 さんは 23 才です。