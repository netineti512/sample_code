#標準ライブラリのモジュールを使う
import calendar   #標準ライブラリをインポートして、

c = calendar.TextCalendar()    #クラスを利用することができます。
c.prmonth(2018, 10)     #メソッドを呼び出し、
c.prmonth(3021,12)


#    October 2018
#Mo Tu We Th Fr Sa Su
# 1  2  3  4  5  6  7
# 8  9 10 11 12 13 14
#15 16 17 18 19 20 21
#22 23 24 25 26 27 28
#29 30 31

#   December 3021
#Mo Tu We Th Fr Sa Su
#                1  2
# 3  4  5  6  7  8  9
#10 11 12 13 14 15 16
#17 18 19 20 21 22 23
#24 25 26 27 28 29 30
#31