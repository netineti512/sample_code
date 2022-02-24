import datetime

dt = datetime.datetime.now()
str = dt.strftime("%c")
print("現在は", str, "です。")

dt = dt + datetime.timedelta(days=1)
str = dt.strftime("%Y-%m-%d")
print("1日後は", str, "です。")


#現在は Thu Feb 24 15:40:44 2022 です。
#1日後は 2022-02-25 です。