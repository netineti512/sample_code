//ファイルに出力する
#include<fstream>
#include<iostream>
using namespace std;

int main()
{
	ofstream fout("test1.txt");
	if (!fout)
	{
		cout << "ファイルをオープンできませんでした。\n";
		return 1;
	}
	else
		cout << "ファイルをオープンしました。\n";

	//ファイルにデータを書き込んでいます。
	fout << "Hello!\n";
	fout << "GoodBye!\n";
	cout << "ファイルに書き込みました。\n";

	fout.close();
	cout << "ファイルをクローズしました。\n";
	return 0;
}