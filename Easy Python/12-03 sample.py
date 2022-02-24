#散布図を描く
import random
import matplotlib.pyplot as plt

x = []
y = []

for i in range(100):
    x.append(random.uniform(0, 50))    #0～50のランダムなxの値を取得します。
    y.append(random.uniform(0, 50))    #0～50のランダムなyの値を取得します。

plt.scatter(x, y)     #散布図を作成します。
plt.show()