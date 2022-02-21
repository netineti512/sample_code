//誤った関数を使ってみる
#include<iostream>
using namespace std;

//誤ったswap関数の宣言
void swap(int x, int y);

//誤ったswap関数の定義
void swap(int x, int y)
{
    int tmp;
    
    tmp = x;
    x = y;
    y = tmp;
}

int main()
{
    int num1 = 5;
    int num2 = 10;
    
    cout << "変数num1の値は" << num1 << "です。\n";
    cout << "変数num2の値は" << num2 << "です。\n";
    cout << "変数num1とnum2の値を変換します。\n";
    
    swap(num1, num2);   //swap()関数を呼び出したが、
    
    cout << "変数num1の値は" << num1 << "です。\n";
    cout << "変数num2の値は" << num2 << "です。\n";
    
    return 0;
}