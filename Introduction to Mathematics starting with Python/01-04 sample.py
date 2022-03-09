#ユーザ入力を受け取る
import math


a = input(">>")   #>>3
print(a)      #3
print()

print(a)       #3
print()

a = '1'
print(int(a) + 1)     #2
print(float(a) + 1)   #2.0
print()

a = float(input(">>"))   #4
print(a)                 #4.0
print()

try:
    a = float(input(">>"))      #>>d
except ValueError:
    print("You entered an invalid number")    #You entered an invalid number
print()

a = int(input(">>"))    #>>4
print(a)                #4
print(a + 1)            #5
print()

print(1.1.is_integer())     #False
print(1.0.is_integer())     #True
print()

import math
z = complex(input("Enter a complex number.>>"))   #>>3+50000000j
print(z)             #3+50000000j