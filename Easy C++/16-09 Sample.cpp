//出力幅の指定
#include<iostream>
#include<iomanip>   /<iomanip>をインクルードします。
using namespace std;

int main()
{
	for (int i = 0; i <= 10; i++)
	{
		cout << setw(3) << i;   //出力幅を3とします。
	}
	cout << "\n";

	return 0;
}