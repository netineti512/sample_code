#numpyを使用したグラフの作成
import numpy as np
import matplotlib.pyplot as plt

x = np.arange(0.0, 2.5, 0.05)* np.pi   #浮動小数点数の間隔を持つ要素を作成することができます。
                                       #要素に対して一度に演算を行うことができます。
#数学関連の高度な処理も一度に行うことができます。
s = np.sin(x)
c = np.cos(x)

plt.title("sin/cos functions")
plt.xlabel("rad")
plt.ylabel("value")
plt.grid(True)

plt.plot(x, s, label="sin")
plt.plot(x, c, label="cos")
plt.legend()

plt.show()