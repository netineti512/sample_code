//変数の記憶寿命を知る
#include<iostream>
using namespace std;

//func関数の宣言
void func();

int a = 0;

//func関数の定義
void func()
{
    int b = 0;   //ローカル変数bです。
    static int c = 0;   //staticをつけたローカル関数cです。
    
    cout << "変数aは" << a << "、変数bは" << b << "、変数cは" << c << "です。\n";
    
    //各変数をインクリメントします。
    a++;
    b++;
    c++;
}

//main関数
int main()
{
    for (int i = 0; i < 5; i++)
    {
        func();
    }
    
    return 0;
}