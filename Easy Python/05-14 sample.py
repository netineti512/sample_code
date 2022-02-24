#リストの内包表記
data = [1, 2, 3, 4, 5]
print("現在のデータは", data, "です。")

ndata = [n*2 for n in data if n! = 3]   #要素を変数を取り出し、条件がTrueであれば、

print("新しいデータは", ndata, "です。")  #式の値を新しいリストの要素とします。