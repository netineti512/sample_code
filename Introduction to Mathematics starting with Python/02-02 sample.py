simplelist = [1, 2, 3]
print(simplelist[0])    #1
print(simplelist[1])    #2
print(simplelist[2])    #3
print()

stringlist = ["a string", "b string", "c string"]
for i in range(3):
    print(stringlist[i])
    #a string
    #b string
    #c string
print()

emptylist = []
print(emptylist)
a = emptylist.append(1)
b = emptylist.append(2)
print(a, b)
print()

simple = (1, 2, 3)
for i in range(3):
    print(simple[i])
    #1
    #2
    #3
print()

l = [1, 2, 3]
for item in l:
    print(item)
    #1
    #2
    #3
print()

for index, item in enumerate(l):
    print(index, item)
    #0 1
    #1 2
    #2 3
print()