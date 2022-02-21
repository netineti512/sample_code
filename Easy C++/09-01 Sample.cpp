//配列要素の値を出力する
#include<iostream>
using namespace std;

int main()
{
    int test[5];    //配列を宣言しています。
    
    //配列要素に1つずつ値を代入します。
    test[0] = 80;
    test[1] = 60;
    test[2] = 22;
    test[3] = 50;
    test[4] = 75;
    
    //繰り返し文を使って配列要素を出力しています。
    for (int i = 0; i < 5; i++)
    {
        cout << i + 1 << "番目の人の点数は" << test[i] << "です。\n";
    }
    
    return 0;
}