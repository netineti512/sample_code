//関数の引数として配列を使う
#include<iostream>
using namespace std;

//avg関数の宣言
double avg(int t[]);   //配列を関数の引数として使います。

//avg関数の定義
double avg(int t[])
{
    double sum = 0;
    for (int i = ; i < 5; i++)
    {
        sum += t[i];   //配列を利用します。
    }
    return sum / 5;
}

int main()
{
    int test[5];
    
    cout << "5人のテストの点数を入力して下さい。\n";
    for (int i = 0; i < 5; i++)
    {
        cin >> test[i];
    }
    double ans = avg(test);   //配列名(配列の先頭要素のアドレス)を実引数として渡します。
    cout << "5人の平均点は" << ans << "点です。\n";
    
    return 0;
}