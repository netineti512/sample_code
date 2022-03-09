#matplotlibでグラフを作る
x_numbers = [1, 2, 3]
y_numbers = [2, 4, 6]
from pylab import plot, show
plot(x_numbers, y_numbers)
show()

plot(x_numbers, y_numbers, marker="o")
show()

plot(x_numbers, y_numbers, "o")
show()

nyc_temp = [53.9, 56.3, 56.4, 53.4, 54.5,
            55.8, 56.8, 55.0, 55.3, 54.0, 56.7, 56.4, 57.3]
plot(nyc_temp, marker="o")
show()

nyc_temp = [53.9, 56.3, 56.4, 53.4, 54.5,
            55.8, 56.8, 55.0, 55.3, 54.0, 56.7, 56.4, 57.3]
years = range(2000, 2013)
plot(years, nyc_temp, marker="o")
show()

nyc_temp_2000 = [31.3, 37.3, 47.2, 51.0, 63.5, 71.3, 72.3, 72.7, 66.0, 57.0, 45.3, 31.1]
nyc_temp_2006 = [40.9, 35.7, 43.1, 55.7, 63.1, 71.0, 77.9, 75.8, 66.6, 56.2, 51.9, 43.6]
nyc_temp_2012 = [37.3, 40.9, 50.9, 54.8, 65.1, 71.0, 78.8, 76.7, 68.8, 58.0, 43.9, 41.5]
months = range(1, 13)
plot(months, nyc_temp_2000, months, nyc_temp_2006, months, nyc_temp_2012)
show()

plot(months, nyc_temp_2000)
show()
plot(months, nyc_temp_2006)
show()
plot(months, nyc_temp_2012)
show()

from pylab import plot, show, title, xlabel, ylabel, legend
plot(months, nyc_temp_2000, months, nyc_temp_2006, months, nyc_temp_2012)
title("Average monthly temperature in NYC")
xlabel("Month")
ylabel("Temperature")
legend([2000, 2006, 2012])
show()

import matplotlib.pyplot
def create_graph():
    x_numbers = [1, 2, 3]
    y_numbers = [2, 4, 6]
    matplotlib.pyplot.plot(x_numbers, y_numbers)
    matplotlib.pyplot.show()
if __name__ == "__main__":
    create_graph()

import matplotlib.pyplot as plt
def create_graph():
    x_numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
    y_numbers = [2, 4, 8, 16, 32, 64, 128, 256, 512, 1024]
    plt.plot(x_numbers, y_numbers)
    plt.show()
if __name__ == "__main__":
    create_graph()

from pylab import plot, savefig
x = [1, 2, 3]
y = [2, 4, 6]
plot(x, y)
show()
savefig("a.png")

import matplotlib.pyplot as plt
def draw_graph(x, y):
    plt.plot(x, y, marker="o")
    plt.xlabel("Distance in meters")
    plt.ylabel("Gravitational force in newtons")
    plt.title("Gravitational force and distance")
    plt.show()
def generate_F_r():
    r = range(100, 1001, 50)
    F = []
    G = 6.674 * (10 ** -11)
    m1 = 0.5
    m2 = 1.5
    for dist in r:
        force = G * (m1 * m2) / (dist ** 2)
        F.append(force)
    draw_graph(r, F)
if __name__ == "__main__":
    generate_F_r()

from matplotlib import pyplot as plt
import math
def draw_graph(x, y):
    plt.plot(x, y)
    plt.xlabel("x-coordinate")
    plt.ylabel("y-coordinate")
    plt.title("Projectile motion of ball")
def frange(start, final, interval):
    numbers = []
    while start < final:
        numbers.append(start)
        start = start + interval
    return numbers
def draw_trajectory(u, theta):
    theta = math.radians(theta)
    g = 9.8
    t_flight = 2*u*math.sin(theta) / g
    intervals = frange(0, t_flight, 0.001)
    x = []
    y = []
    for t in intervals:
        x.append(u*math.cos(theta)*t)
        y.append(u*math.sin(theta)*t - 0.5*g*t*t)
    draw_graph(x, y)
if __name__=="__main__":
    try:
        u = float(input("Enter the iniial velocity (m/s):>>"))                #>>25
        theta = float(input("Enter the angle of projection (degrees):>>"))    #>>60
    except ValueError:
        print("You enterd an invalid input")
    else:
        draw_trajectory(u, theta)
        plt.show()

if __name__ == "__main__":
    u_list = [20, 40, 60]
    theta = 45
    for u in u_list:
        draw_trajectory(u, theta)
    plt.legend(["20", "40", "60"])
    plt.show()