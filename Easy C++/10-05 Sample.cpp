//ファイルを分割する
#include<iostream>
#include "10-05 Sample.h"   //ヘッダファイルを読み込みます
using namespace std;

int main()
{
    int num1, num2, ans;

    cout << "1番目の整数を入力して下さい。\n";
    cin >> num1;

    cout << "2番目の整数を入力して下さい。\n";
    cin >> num2;

    //別ファイルの関数を呼び出します。
    ans = max (num1, num2);

    cout << "最大値は" << ans << "です。\n";

    return 0;
}