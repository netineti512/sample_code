#include<iostream>
using namespace std;

//max関数の宣言
int max(int x, int y);
double max(double mx, double y);

//max関数(int型)の定義
int max(int x, int y)
{
	if (x > y)
		return x;
	else
		return y;
}

//max関数(double型)の定義
double max(double x, double y)
{
	if (x > y)
		return x;
	else
		return y;
}

int main()
{
	int a, b;
	double da, db;

	cout << "2つの整数を入力して下さい。\n";
	cin >> a >> b;

	cout << "2つの少数を入力して下さい。\n";
	cin >> da >> db;

	int ans1 = max(a, b);
	double ans2 = max(da, db);

	cout << "整数値の最大値は" << ans1 << "です。\n";
	cout << "小数値の最大値は" << ans2 << "です。\n";

	return 0;
}