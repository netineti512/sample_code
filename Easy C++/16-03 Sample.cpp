//width()関数を使う
#include<iostream>
using namespace std;

int main()
{
	for (int i = 0; i <= 10; i++)
	{
		cout.width(3);   //出力幅を3とする。
		cout << i;
	}
	cout << "\n";

	return 0;
}