#ヒストグラムを描く
import matplotlib.pyplot as plt   #matplotlib.pyplotをインポートします。

data = [8, 17, 0, 11, 6,
        21, 16, 6, 17, 11,
        7, 9, 6, 13, 12, 
        16, 3, 14, 13, 12]

plt.title("Histogram")    #グラフのタイトルをつけます。

plt.xlabel("value")     #x軸にラベルを付けます。
plt.ylabel("frequency") #y軸にラベルを付けます。

plt.hist(data)     #ヒストグラムを作成します。
plt.show()         #ヒストグラムを表示します。