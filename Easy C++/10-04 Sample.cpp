//配列を動的に確保する
#include<iostream>
using namespace std;

int main()
{
    int numl
    int* pT;

    cout << "何人のテストの点数を入力しますか？"\n;

    cin >> num;    //キーボードから数値を入力させ、

    pT = new int[num];    //その分だけの配列要素を確保します。

    cout << "人数分の点数を入力てください。\n";

    for (int i = 0; i < num; i++)
    {
        cin >> pT[i];   //ポインタを使って点数を記憶します。
    }

    for (int j= 0; j < num; j++)
    {
        cout << j + 1 << "番目の人の点数は" << pT[j] << "です。\n";
    }

    delete[] pT;

    return 0;
}