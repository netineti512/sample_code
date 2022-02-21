//例外処理を行う
#include<iostream>
using namespace std;

int main()
{
	int num;
	cout << "1～9までの数字を入力して下さい。\n";
	cin >> num;

	try {
		if (num <= 0)
		{
			throw "0以下を入力しました。\n";
		}
		if (num >= 10)
		{
			throw "10以上を入力しました。\n";   //例外を送出します。
		}

		cout << num << "です。\n";
	}

	//例外処理を行います
	catch (char* err)
	{
		cout << "エラー：" << err << "\n";
		return 1;
	}
	return 0;
}