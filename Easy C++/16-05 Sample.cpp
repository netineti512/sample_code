//precision()関数を使う
#include<iostream>
using namespace std;

int main()
{
	double pi = 3.141592;
	int num;

	cout << "円周率を出力します。\n";
	cout << "有効桁何桁で出力しますか？(1～7)\n";
	cin >> num;

	cout.precision(num);   //出力の際の有効桁を指定します。

	cout << "円周率は" << pi << "です。\n";

	return 0;
}