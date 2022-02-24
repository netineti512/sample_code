#リストを作成する
data1 = [1, 2, 3, 4, 5]
data2 = list(data1)   #リストを新しく作成して、代入を行うと、

print("data1は", data1, "です。")
print("data2は", data2, "です。")

data1[0] = 10

print("data1を変更します。")

print("data1は", data1, "です。")
print("data2は", data2, "です。")

#data1は [1, 2, 3, 4, 5] です。
#data2は [1, 2, 3, 4, 5] です。
#data1を変更します。
#data1は [10, 2, 3, 4, 5] です。
#data2は [1, 2, 3, 4, 5] です。