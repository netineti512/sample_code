#数学を行うプログラムを書く
def is_factor(a, b):
    if b % a == 0:
        return True
    else:
        return False
c = is_factor(4, 1024)
print(c)      #True
print()

for i in range(1, 4):
    print(i)     #1, 2, 3
print()

for i in range(5):
    print(i)      #0, 1, 2, 3, 4
print()

for i in range(1,10, 2):
    print(i)       #1, 3, 5, 7, 9
print()

def factors(b):
    for i in range(1, b+1):
        if b % i== 0:
            print(i)
factors(100)      #1, 2, 4, 6, 10, 20, 25, 100
print()

if __name__ == '__main__':
    b = input("Your Number Please:")
    b = float(b)
    
    if b > 0 and b.is_integer():
        factors(int(b))     #>>100   #1, 2, 4, 6, 10, 20, 25, 100
    else:
        print("Please enter a positive integer")
print()

item1 = 'apples'
item2 = 'nababas'
item3 = 'grapes'
print("at the grocery store, I bought some {0} and {1} and {2}".format(item1, item2, item3))
print()     #at the grocery store, I bought some apples and nababas and grapes

print("Nuber 1：{0}、Number 2：{1}".format(1, 3.578))
print()     #Nuber 1：1、Number 2：3.578

def multi_table(a):
    for i in range(1, 11):
        print("{0} × {1} = {2}".format(a, i, a*i))
if __name__== '__main__':
    a = input("Enter a number:>>")     #>>3
    multi_table(float(a))
#3.0 × 1 = 3.0
#3.0 × 2 = 6.0
#3.0 × 3 = 9.0
#3.0 × 4 = 12.0
#3.0 × 5 = 15.0
#3.0 × 6 = 18.0
#3.0 × 7 = 21.0
#3.0 × 8 = 24.0
#3.0 × 9 = 27.0
#3.0 × 10 = 30.0
print()

a = "{0}".format(1.23456)
print(a)     #1.23456
b = "{0:.2f}".format(1.23456)
print(b)     #1.23

c = "{0:.2f}".format(1.25556)
print(c)       #1.26
d = "{0:.2f}".format(1)
print(d)       #1.00
print()

a = (25.5 * 2.54) / 100
print(a)     #0.6476999999999999
b = 650 * 1.609
print(b)      #1045.85
print()

F = 98.6
f = (F - 32) * (5 / 9)
print(f)     #37.0
print()

C = 37
c = C * (9 / 5) + 32
print(c)     #98.60000000000001
print()

def print_menu():
    print("1. Kilometers to Miles")
    print("2. Miles to Kilometers")
def km_miles():
    km = float(input("Enter distamce in kilometers:>>"))
    miles = km / 1.609
    print("Distance in miles: {0}".format(miles))
def miles_km():
    miles = float(input("Enter distance in miles:>>"))
    km = miles * 1.609
    print("Distance  kilometers:{0}".format(km))
if __name__=="__main__":
    print_menu()
    choice = input("Which conversion would you like to do?:>>")   #>>1
    if choice == "1":
        km_miles()      #>>3000     #1864.5121193287757
    if choice == "2":
        miles_km()
print()

x = 10 - 100 + 79
print(x)     #-11
print()

a = 1
b = 2
c = 1
D = (b**2 - 4 * a * c)** 0.5
x_1 = (-b + D) / (2*a)
print(x_1)    #-1.0
x_2 = (-b + D) / (2*a)
print(x_2)    #-1.0
print()

def roots(a, b, c):
    D = (b*b - 4*a*c) ** 0.5
    x_1 = (-b + D) / (2*a)
    x_2 = (-b - D) / (2*a)
    print("x1:{0}".format(x_1))
    print("x2:{0}".format(x_2))
if __name__ == "__main__":
    a = input("Enter a:>>")     #30
    b = input("Enter b:>>")     #29
    c = input("Enter c:>>")     #99
    roots(float(a), float(b), float(c))
                #x1:(-0.34999999999999987+1.7825543469975889j)
                #x2:(-0.35000000000000014-1.7825543469975889j)
print()