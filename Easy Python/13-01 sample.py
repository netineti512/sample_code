#線形回帰を行う
from sklearn import datasets
from sklearn import linear_model
from sklearn.model_selection import train_test_split
import matplotlib.pyplot as plt
import numpy as np

np.random.seed(0)     #乱数のシードを設定しています。

x, y = datasets.make_regression(n_samples=100, n_features=1, noise=30)     #線形回帰のデータを準備しておきます。

x_train, x_test, y_train, y_test = train_test_split(x, y, test_size=0.3)     #学習データとテストデータを分割します。

e = linear_model.LinearRegression()    #回帰を行うためのインスタンスを取得します。
e.fit(x_train, y_train)    #当てはめを行います。

#回帰も出るを取得します。
print("回帰係数は", e.coef_, "です。")
print("切片は", e.intercept_, "です。")

y_pred = e.predict(x_test)     #テストデータから予測を行います。

print("学習データによる決定係数は", e.score(x_train, y_train), "です。")    #学習データに対するモデルの当てはまりを評価します。
print("テストデータによる決定係数は", e.score(x_test, y_test), "です。")    #テストデータに対するモデルの当てはまりを評価します。

plt.scatter(x_train, y_train, label="train")    #学習データをプロットします。
plt.scatter(x_test, y_test, label="test")       #テストデータをプロットします。
plt.plot(x_test, y_pred, color="magenta")       #相木直線をプロットします。
plt.legend()

plt.show()


#回帰係数は [45.53155127] です。
#切片は -5.4206693967270025 です。
#学習データによる決定係数は 0.6920076270690864 です。
#テストデータによる決定係数は 0.5033443224342988 です。