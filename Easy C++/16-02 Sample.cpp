//1文字入出力関数を使う
#include<iostream>
using namespace std;

int main()
{
	char ch;

	cout << "文字を続けて入力して下さい。\n";

	while (cin.get(ch))   //1文字ずつ読み込みます。
	{
		cout.put(ch);     //1文字ずつ出力します。
	}

	return 0;
}