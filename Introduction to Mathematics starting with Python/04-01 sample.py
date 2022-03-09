#式の記号と記号演算を定義する。
x = 1
print(x + x + 1)
print()

from sympy import Symbol
x = Symbol("x")
print(x + x + 1)
print()

a = Symbol("x")
print(a + a + 1)
print()

x = Symbol("x")
print(x.name)
a = Symbol("x")
print(a.name)
print()

from sympy import symbols
x, y, z = symbols("x, y, z")
print(x, y, z)
print()

s = x * y + x * y
print(s)
print()

p = x * (x + x)
print(p)
print()

p = (x + 2)*(x + 3)
print(p)
print()

p = (x+2)**(x+2)
print(p)
print()

#式の因数分解と展開
from sympy import Symbol
x = Symbol("x")
y = Symbol("y")
from sympy import factor
expr = x**2 - y**2
a = factor(expr)
print(a)
print()

expr = x**3 + 3*x**2*y + 3*x*y**2 + y**3
factors = factor(expr)
print(factors)
print()

expr = x + y + x*y
a = factor(expr)
print(a)
print()

#プリティプリント
expr = x*x + 2*x*y + y*y
print(expr)
from sympy import pprint
pprint(expr, use_unicode=True)
expr = 1 + 2*x + 2*x**2
pprint(expr, use_unicode=True)
print()

from sympy import init_printing
init_printing(order="rev-lex")
pprint(expr, use_unicode=True)
print()

#級数を出力する
from sympy import Symbol, pprint, init_printing
def print_series(n):
    init_printing(order="rev-lex")
    x = Symbol("x")
    series = x
    for i in range(2, n+1):
        series = series + (x**i)/i
    pprint(series)
if __name__ == "__main__":
    n = input("Enter the number of terms you want in the series:")
    print_series(int(n))
print()

#値に代入する
x = Symbol("x")
y = Symbol("y")
a = x*x + x*y + x*y + y*y
print(a)
res = a.subs({x:1, y:2})
print(res)
b = a.subs({x:1-y})
print(b)
print()

expr_subs = a.subs({x:1-y})
from sympy import simplify
c = simplify(expr_subs)
print(c)
print()

#級数の値を計算する
from sympy import Symbol, pprint, init_printing
def print_series(n, x_value):
    init_printing(order="rev-lex")
    x = Symbol("x")
    series = x
    for i in range(2, n+1):
        series = series + (x**i) / i
    pprint(series)
    series_value = series.subs({x:x_value})
    print("Value of the series at {0}:{1}".format(x_value, series_value))
if __name__ == "__main__":
    n = input("Enter the number if terms you want in the series:")
    x_value = input("Enter the value of x at which you want to evaluate the series:")
    print_series(int(n), float(x_value))
print()

#文字列を数式に変換する
from sympy import sympify
expr = input("Enter a mathmatical expression:")
expr = sympify(expr)
print(expr)
print(2*expr)
print()

from sympy import sympify
from sympy.core.sympify import SympifyError
expr = input("Enter a mathmatical expression:")
try:
    expr = sympify(expr)
except SympifyError:
    print("Invalid input")
print()

#数式乗算器
from sympy import expand, sympify
from sympy.core.sympify import SympifyError
def product(expr1, expr2):
    prod = expand(expr1 * expr2)
    print(prod)
if __name__ == "__main__":
    expr1 = input("Enter the first expression:")
    expr2 = input("Rnter the second expression:")
    try:
        expr1 = sympify(expr1)
        expr2 = sympify(expr2)
    except SympifyError:
        print("Invalid input")
    else:
        product(expr1, expr2)
print()

#方程式を解く
from sympy import Symbol, solve
x = Symbol("x")
expr = x - 5 - 7
ans = solve(expr)
print(ans)

#2次方程式を解く
from sympy import Symbol, solve
x = Symbol("x")
expr = x**2 + 5*x + 4
a = solve(expr, dict=True)
print(a)
print()

x = Symbol("x")
expr = x**2 + x + 1
b = solve(expr, dict=True)
print(b)
print()

#1変数を他の変数について解く
x = Symbol("x")
a = Symbol("a")
b = Symbol("b")
c = Symbol("c")

expr = a*x*x + b*x + c
d = solve(expr, x, dict=True)
print(d)
print()

