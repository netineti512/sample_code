//書式状態フラグの設定
#include<iostream>
using namespace std;

int main()
{
	cout.setf(ios::left, ios::adjustfield);   //左寄せで出力します。
	for (int i = 0; i <= 5; i++)
	{
		cout.width(5);
		cout.fill('-');
		cout << i;
	}
	cout << "\n";
	cout.unsetf(ios::left);   //左寄せを解除します。
	cout.setf(ios::right, ios::adjustfield);   //右寄せで出力します。
	for (int j = 0; j <= 5; j++)
	{
		cout.width(5);
		cout.fill('-');
		cout << j;
	}
	cout << "\n";
	
	return 0;
}