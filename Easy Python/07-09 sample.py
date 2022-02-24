#ラムダを使う
data = [1, 2, 3, 4, 5]

for d in map(lambda x: x*2, data):  #無名関数とリストを、map()関数で組み合わせます。
    print(d)


#2
#4
#6
#8
#10