//演算子を使う
#include<iostream>
using namespace std;

int main()
{
	int i;
	double d;
	char str[100];

	//いろいろな型の入出力が行えます。
	cout << "整数値を入力して下さい。\n";
	cin >> i;
	cout << "小数値を入力して下さい。\n";
	cin >> d;
	cout << "文字列を入力して下さい。\n";
	cin >> str;

	cout << "入力した整数値は" << i << "です。\n";
	cout << "入力した整数値は" << d << "です。\n";
	cout << "入力した文字列は" << str << "です。\n";

	return 0;
}