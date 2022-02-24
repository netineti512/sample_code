#クラスタリングを行う
from sklearn import datasets
from sklearn import cluster
import matplotlib.pyplot as plt

data, label = datasets.make_blobs(n_samples=500, n_features=2, centers=5)     #クラスタリングを行うためのデータを作成しておきます。

e = cluster.KMeans(n_clusters=5)     #k-means法を行うインスタンスです。
e.fit(data)      #クラスタリングを行います。

print(e.labels_)     #各データが属するクラスタ(ラベル)を取得します。
print(e.cluster_centers_)     #クラスタの中心を取得します。

plt.scatter(data[:, 0], data[:, 1], marker="o", c=e.labels_, edgecolor="k")    #データを散布図に作成します。
plt.scatter(e.cluster_centers_[:, 0], e.cluster_centers_[:, 1], marker="x")    #クラスタの中心を散布図に作成します。

plt.show()