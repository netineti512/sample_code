#さまざまな種類の数
print(type(3))
print(type(3.5))
print(type(3.0))
print()

print(int(3.8))
print(int(3.0))
print()

print(float(3))
print()

from fractions import Fraction
f = Fraction(3, 4)
print(f)
print()

print(Fraction(3, 4) + 1 + 1.5)
print()

print(Fraction(3, 4) + 1 + Fraction(1/4))
print()

a = 2 + 3j
print(type(a))
print(a)
print()

a = complex(2, 3)
print(a)
print()

b = 3 + 3j
print(a + b)
print(a - b)
print()

print(a * b)
print(a / b)
print()

z = 2 + 3j
print(z.real)
print(z.imag)
print()

print(z.conjugate())
print()

print((z.real * 2 + z.imag ** 2) ** 0.5)
print()

print(abs(z))
print()


#3
#3

#3.0

#3/4

#3.25

#2

#<class 'complex'>
#(2+3j)

#(2+3j)

#(5+6j)
#(-1+0j)

#(-3+15j)
#(0.8333333333333334+0.16666666666666666j)

#2.0
#3.0

#(2-3j)

#3.605551275463989

#3.605551275463989