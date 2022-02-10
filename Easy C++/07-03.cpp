#include<iostream>
using namespace std;

//buy関数の定義
void buy(int x)
{
	cout << x << "万円の車を買いました。\n";
}

//buy関数の利用
int main()
{
	buy(20);
	buy(50);

	return 0;
}