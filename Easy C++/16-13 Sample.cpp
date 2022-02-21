//ファイルから入力する
#include<fstream>
#include<iostream>
using namespace std;

int main()
{
	ifstream fin("test.txt");   //ファイルをオープンします(ifstreamクラスのオブジェクトを作成します。)
	if (!fin)
	{
		cout << "ファイルをオープンでいませんでした。\n";
		return 1;
	}

	//ファイルからデータを読み込んでいます。
	char str1[16];
	char str2[16];
	fin >> str1 >> str2;
	cout << "ファイルに書き込まれている2つの文字列は\n";
	cout << str1 << "です。\n";
	cout << str2 << "です。\n";

	fin.close();

	return 0;
}