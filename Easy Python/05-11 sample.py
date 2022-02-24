#逆順にする際の注意
data = [1, 2, 3, 4, 5]
print("現在のデータは", data, "です。")

print("data[::-1]をfor文で処理します。")
for d in data[::-1]:   #スライスで処理します。
    print(d)
print("data[::-1]は", data[::-1], "です。")
print("現在のデータは", data, "です。")

print("reversed(data)は", reversed(data), "です。")
for d in reversed(data):   #reversed()関数で処理します。
    print(d)
print("reversed(data)は", reversed(data), "です。")
print("現在のデータは", data, "です。")

print("data.reverse()を処理します。")   #reverse()メソッドで処理します。
data.reverse()
print("現在のデータは", data, "です。")


#現在のデータは [1, 2, 3, 4, 5] です。
#data[::-1]をfor文で処理します。
#5
#4
#3
#2
#31
#data[::-1]は [5, 4, 3, 2, 1] です。
#現在のデータは [1, 2, 3, 4, 5] です。
#reversed(data)は <list_reverseiterator object at 0x00000259559C7F70>です。
#5
#4
#3
#2
#1
#reversed(data)は <list_reverseiterator object at 0x00000259559C7F70>です。
#現在のデータは [1, 2, 3, 4, 5] です。
#data.reverse()を処理します。
#現在のデータは [5, 4, 3, 2, 1] です。