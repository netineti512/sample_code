//アルゴリズムを利用する
#include<iostream>
#include<vector>
#include<algorithm>   //<algorithm>をインクルードします。
using namespace std;

int main()
{
	vector<int> vt;
	for (int i = 0; i < 10; i++)
	{
		vt.push_back(i);
	}

	cout << "並び替え前は\n";
	vector<int>::iterator it = vt.begin();
	while (it != vt.end())
	{
		cout << *it;
		it++;
	}
	cout << "です。\n";

	//逆順にします。
	cout << "逆順にすると";
	reverse(vt.begin(), vt.end());
	it = vt.begin();
	while (it != vt.end)
	{
		cout << *it;
		it++;
	}
	cout << "です。\n";

	//並び替えます。
	cout << "並び替え後は\n";
	sort(vt.begin(), vt.end());
	it = vt.begin();
	while (it != vt.end())
	{
		cout << *it;
		it++;
	}
	cout << "です。\n";

}