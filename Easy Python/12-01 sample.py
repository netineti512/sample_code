#統計指標を得る
import statistics     #統計を扱うstatisticsモジュールをインポートする。

data = [8, 17, 0, 11, 6,
        21, 16, 6, 17, 11,
        7, 9, 6, 13, 12,
        16, 3, 14, 13, 12]     #統計対象のデータを準備する。

#各種統計指標を取得します。
print("平均値は", statistics.mean(data), "です。")
print("中央値は", statistics.median(data), "です。")
print("最頻値は", statistics.mode(data), "です。")
print("分散は", statistics.pvariance(data), "です。")
print("標準偏差は", statistics.pstdev(data), "です。")


#平均値は 10.9 です。
#中央値は 11.5 です。
#最頻値は 6 です。
#分散は 26.49 です。
#標準偏差は 5.146843692983108 です。