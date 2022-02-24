#クラス変数・クラスメソッド
class Person:
    count = 0     #クラス変数です。
    
    def __init__(self, name, age):     #インスタンスが作成されたときに、
        Person.count = Person.count + 1   #クラス変数であるcountを1増やします。
        
        self.name = name
        self.age = age
    
    def getName(self):
        return self.name
    
    def getAge(self):
        return self.age
    
    @classmethod    #クラスメソッドです。
    def getCount(cls):
        return cls.count

pr1 = Person("鈴木", 23)
pr2 = Person("佐藤", 38)

print(pr1.getName(), "さんは", pr1.getAge(), "才です。")
print(pr2.getName(), "さんは", pr2.getAge(), "才です。")
print("合計人数は", Person.getCount(), "です。")     #クラスメソッドを呼び出します。


#鈴木 さんは 23 才です。
#佐藤 さんは 38 才です。
#合計人数は 2 です。