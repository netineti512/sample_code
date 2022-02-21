//標準ライブラリのstrlen()関数を使う
#include<iostream>
#include<cstring>   //文字列操作関数を提供する標準ライブラリを扱えるようにします。
using namespace std;

int main()
{
    char str[100];
    
    cout << "文字列(英数字)を入力して下さい。\n";
    
    cin >> str;
    
    cout << "文字列の長さは" << strlen(str) << "です。\n";   //文字列操作関数を利用します。
    
    return 0;
}