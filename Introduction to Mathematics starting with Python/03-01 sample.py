#平均を求める
shortlist = [1, 2, 3]
print(sum(shortlist))     #6
print(len(shortlist))     #3
print()

def calculate_mean(numbers):
    s = sum(numbers)
    N = len(numbers)
    mean = s / N
    return mean
if __name__=="__main__":
    donations = [10, 60, 70, 900, 100, 200, 500, 500, 503, 600, 1000, 1200]
    mean = calculate_mean(donations)
    N = len(donations)
    print("Mean donations over the last {0} days is {1}".format(N, mean))
    #Mean donations over the last 12 days is 470.25
print()

samplelist = [4, 1, 3]
samplelist.sort()
print(samplelist)     #[1, 3, 4]
print()

def calculate_median(numbers):
    N = len(numbers)
    numbers.sort()
    if N % 2 == 0:
        m1 = N / 2
        m2 = (N/2) + 1
        #convert to integer, match position
        m1 = int(m1) -1
        m2 = int(m2) -1
        median = (numbers[m1] + numbers[m2]) / 2
    else:
        m = (N+1) / 2
        #convert to integer, match position
        m = int(m) - 1
        median = numbers[m]
        return median
if __name__ == "__main__":
    dobations = [100, 60, 70, 900, 100, 200, 500, 500, 503, 600, 1000, 1200]
    median = calculate_median(donations)
    N = len(donations)
    print("Median donation over the last {0} days is {1}".format(N, median))
    #Median donation over the last 12 days is None
print()

simplelist = [4, 2, 1, 3, 4]
from collections import Counter
c = Counter(simplelist)
print(c.most_common())     #[(4, 2), (2, 1), (1, 1), (3, 1)]
print()

print(c.most_common(1))     #[(4, 2)]
print(c.most_common(2))     #[(4, 2), (2, 1)]
print()

mode = c.most_common(1)
print(mode)        #[(4, 2)]
print(mode[0])     #(4, 2)
print(mode[0][0])  #4
print()

#最頻値を探す
from collections import Counter
def calculate_mode(numbers):
    c = Counter(numbers)
    mode = c.most_common(1)
    return mode[0][0]
if __name__ == "__main__":
    scores = [7, 8, 9, 2, 10, 9, 9, 9, 9, 4, 5, 6, 1, 5, 6, 7, 8, 1, 10]
    mode = calculate_mode(scores)
    print("The mode of the list of numbers is: {0}".format(mode))
    #The mode of the list of numbers is: 9
print()

from collections import Counter
def calculate_mode(numbers):
    c = Counter(numbers)
    numbers_freq = c.most_common()
    max_count = numbers_freq[0][1]
    modes = []
    for num in numbers_freq:
        if num[1] == max_count:
            modes.append(num[0])
    return modes
if __name__ == "__main__":
    scores = [5, 5, 5, 4, 4, 4, 9, 1, 3]
    modes = calculate_mode(scores)
    print("The mode(s) of the list of numbers are:")
    for mode in modes:
        print(mode)
#The mode(s) of the list of numbers are:
#5
#4
print()

#度数分布表を作る
from collections import Counter
def frequency_table(numbers):
    table = Counter(numbers)
    print("Number\tFrequency")
    for number in table.most_common():
        print("{0}\t{1}".format(number[0], number[1]))
if __name__ == "__main__":
    scores = [7, 8, 9, 2, 10, 9, 9, 9, 9, 4, 5, 6, 1, 5, 7, 8, 6, 1, 10]
    frequency_table(scores)
#Number  Frequency
#9       5
#7       2
#8       2
#10      2
#5       2
#6       2
#1       2
#2       1
#4       1
print()

from collections import Counter
def frequency_table(numbers):
    table = Counter(numbers)
    numbers_freq = table.most_common()
    numbers_freq.sort()
    print("number\tFrequency")
    for number in numbers_freq:
        print("{0}\t{1}".format(number[0], number[1]))
if __name__ == "__main__":
    scores = [7, 8, 9, 2, 10, 9, 9, 9, 9, 4, 5, 6, 1, 5, 7, 8, 6, 1, 10]
    frequency_table(scores)
#number  Frequency
#1       2
#2       1
#4       1
#5       2
#6       2
#7       2
#8       2
#9       5
#10      2
print()

#散らばりを図る
def find_range(numbers):
    lowest = min(numbers)
    highest = max(numbers)
    #find the range
    r = highest - lowest
    return lowest, highest, r
if __name__ == "__main__":
    donations = [100, 60, 70, 900, 100, 200, 500, 500, 503, 600, 1000, 1200]
    lowest, highest, r = find_range(donations)
    print("Lowest：{0}、Highest：{1}、Rabge：{2}".format(lowest, highest, r))
#Lowest：60、Highest：1200、Rabge：1140
print()

#分散と標準偏差を求める
def calculate_mean(numbers):
    s = sum(numbers)
    N = len(numbers)
    #calculate the mean
    mean = s / N
    return mean
def find_differences(numbers):
    #find the mean
    mean = calculate_mean(numbers)
    #find the differences from the mean
    diff = []
    for num in numbers:
        diff.append(num-mean)
    return diff
def calculate_variance(numbers):
    #find the list of distances
    diff = find_differences(numbers)
    squared_diff = []
    for d in diff:
        squared_diff.append(d**2)
    #find the variance
    sum_squared_diff = sum(squared_diff)
    variance = sum_squared_diff / len(numbers)
    return variance
if __name__ == "__main__":
    donations = [100, 60, 70, 900, 100, 200, 500, 500, 503, 600, 1000, 1200]
    variance = calculate_variance(donations)
    print("The variance of the list of numbers is {0}".format(variance))
    std = variance ** 0.5
    print("The standard of deviation of the list of numbers is {0}".format(std))
#The variance of the list of numbers is 141047.35416666666
#The standard of deviation of the list of numbers is 375.5627166887931
print()

#2つのデータセットの相関を計算する
simple_list1 = [1, 2, 3]
simple_list2 = [4, 5, 6]
for x, y in zip(simple_list1, simple_list2):
    print(x, y)
#1 4
#2 5
#3 6
print()

def find_corr_x_y(x, y):
    n = len(x)
    #find the sum of the products
    prod = []
    for xi, yi in zip(x, y):
        prod.append(xi * yi)
    sum_prod_x_y = sum(prod)
    sum_x = sum(x)
    sum_y = sum(y)
    squared_sum_x = sum_x ** 2
    squared_sum_y = sum_y ** 2
    x_square = []
    for xi in x:
        x_square.append(xi ** 2)
    #find the sum
    x_square_sum = sum(x_square)
    y_square = []
    for yi in y:
        y_square.append(yi ** 2)
    #find the sum
    y_square_sum = sum(y_square)
    #use formula to calculate correlation
    numerator = n * sum_prod_x_y - sum_x * sum_y
    denominator_term1 = n * x_square_sum - squared_sum_x
    denominator_term2 = n * y_square_sum - squared_sum_y
    denominator = (denominator_term1 * denominator_term2) ** 0.5
    correlation = numerator / denominator
    return correlation
print()

#散布図
x = [1, 2, 3, 4]
y = [2, 4, 6, 8]
import matplotlib.pyplot as plt
plt.scatter(x, y)
plt.show()

#テキストファイルからデータを読み込む
#mydata.txt
#100, 60, 70, 900, 100, 200, 500, 500, 503, 600, 1000, 1200

#find the sum of numbers stored in a file
def sum_data(filename):
    s = 0
    with open(filename) as f:
        for line in f:
            s = s + float(line)
    print("Sum of the numbers：{0}".format(s))
if __name__ == "__main__":
    sum_data("mydata.txt")
#Sum of the numbers：5233.0
print()

#calculating the mean of numbers stored in a file
def read_data(filename):
    numbers = []
    with open(filename) as f:
        for line in f:
            numbers.append(float(line))
    return numbers
def calculate_mean(numbers):
    s = sum(numbers)
    N = len(numbers)
    mean = s / N
    return mean
if __name__ == "__main__":
    data = read_data("mydata.txt")
    mean = calculate_mean(data)
    print("Mean：{0}".format(mean))
#Mean：475.72727272727275
print()

#CSVファイルからデータを読み込む
#data.csv
#Number,Squared
#10,100
#9,81
#22,484

import csv
import matplotlib.pyplot as plt
def scatter_plot(x, y):
    plt.scatter(x, y)
    plt.xlabel("Nmber")
    plt.ylabel("Square")
    plt.show()
def read_csv(filename):
    numbers = []
    squared = []
    with open(filename) as f:
        reader = csv.reader(f)
        next(reader)
        for row in reader:
            numbers.append(int(row[0]))
            squared.append(int(row[1]))
    return numbers, squared
if __name__ == "__main__":
    numbers, squared = read_csv("data.csv")
    scatter_plot(numbers, squared)