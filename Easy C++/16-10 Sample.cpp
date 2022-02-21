//ファイルの基本操作をする
#include<fstream>   //<fstream>をインクルードします
#include<iostream>
using namespace std;

int main()
{
	ofstream fout("test0.txt");   //ファイルをオープンします。
	if (!fout)     //オープンでいない時はエラー処理をします。
	{
		cout << "ファイルをオープンできませんでした。\n";
		return 1;
	}
	else
	{
		cout << "ファイルをオープンしました。\n";
	}

	fout.close();    //ファイルをクローズします。
	cout << "ファイルをクローズしました。\n";

	return 0;
}