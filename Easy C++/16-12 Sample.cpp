//ファイルに出力する
#include<fstream>
#include<iostream>
#include<iomanip>
using namespace std;

int main()
{
	ofstream fout("test2.txt");
	if (!fout)
	{
		cout << "ファイルをオープンできませんでした。\n";
		return 1;
	}

	//データをキーボードから入力します。
	const int num = 5;
	int test[num];
	cout << num << "人の点数を入力して下さい。\n";
	for (int i = 0; i < num; i++)
	{
		cin >> test[i];
	}

	//ファイルにデータを書き込んでいます。
	for (int j = 0; j < num; j++)
	{
		fout << "No." << j + 1 << setw(5) << test[j] << "\n";   //画面への出力と同時に書式設定を行うことができます。
	}

	fout.close();

	return 0;
}