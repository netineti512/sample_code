//関数の引数にポインタを使う
#include<iostream>
using namespace std;

//swap関数の宣言
void swap(int* pX, int*pY);

//swap関数の定義
//引数にポインタを使った関数の定義です。
swap(int* pX, int* pY)
{
    tmp = *pX;
    *pX = *pY;
    *pY = tmp;
}

int main()
{
    int num1 = 5;
    int num2 = 10;
    
    cout << "変数num1の値は" << num1 << "です。\n";
    cout << "変数num2の値は" << num2 << "です。\n";
    cout << "変数num1とnum2の値を変換します。\n";
    
    //アドレスを渡して新しいswap()関数を呼び出します。
    swap(&num1, &num2);
    
    cout << "変数num1の値は" << num1 << "です。\n";
    cout << "変数num2の値は" << num2 << "です。\n";
    
    return 0;
}