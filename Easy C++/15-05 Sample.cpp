//ベクタを利用する
#include<iostream>
#include<vector>   //<vector>ヘッダをインクルードします。
using namespace std;

int main()
{
	int num;
	vector<int> vt;   //ベクタを利用できます。
	cin >> num;

	for (int i = 0; i < num; i++)
	{
		int data;
		cout << "整数を入力して下さい。\n";
		cin >> data;
		vt.push_back(data);   //ベクタの末尾に追加できます。
	}
	
	cout << "表示します。\n";   //先頭のベクタを知ることができます。
	vector<int>::iterator it = vt.begin();
	while (it != vt.end())
	{
		cout << *it;
		cout << "-";
		it++;
	}
	cout << "\n";
}