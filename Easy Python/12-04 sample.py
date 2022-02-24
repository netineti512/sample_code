#数学関数のグラフを描く
import math      #数学関連機能を扱うmathモジュールをインポートします。
import matplotlib.pyplot as plt

x = []
s = []
c = []

for i in range(50):
    x.append(i*0.05*math.pi)     #xの値を作成します。
    s.append(math.sin(x[i]))     #sin値を作成します。
    c.append(math.cos(x[i]))     #cos値を作成します。

plt.title("sin/cos function")
plt.xlabel("rad")
plt.ylabel("value")
plt.grid(True)     #グリッドを表示します。

plt.plot(x, s, label="sin")     #sin()関数のグラフをラベル付きで作成します。
plt.plot(x, c, label="cos")     #cos()関数のグラフをラベルつきで作成します。
plt.legend()    #ラベルから凡例を作成します。

plt.show()