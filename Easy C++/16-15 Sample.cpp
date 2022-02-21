//コマンドライン引数を使う
#include<fstream>
#include<iostream>
using namespace std;

int main(int argc, char* argv[])
{
	if (argc != 2)   //入力した文字列の個数を調べます。
	{
		cout << "パラメータの数が違います。\n";
		return 1;
	}

	ifstream fin(argv[1]);   //入力した2番目の文字列を指定して、ファイルをオープンします。
	if (!fin)
	{
		cout << "ファイルをオープンできませんでした。\n";
		return 1;
	}

	char ch;
	fin.get(ch);   //ファイルから1文字読み込みます。

	while (!fin.eof())   //ファイルの終わりに達するまで繰り返します。
	{
		cout.put(ch);   //画面に1文字出力します。
		fin.get(ch);    //次の文字を読み込みます。
	}

	fin.close();

	return 0;
}