//構造体へのポインタを関数の引数に使う
#include<iostream>
using namespace ctd;

//構造体型Carの宣言
struct Car{
    int num;
    double gas;
};

//show関数の宣言
void show(Car* pC);   //構造体へのポインタを引数に持つ関数です。

//show関数の定義
void show(Car* pc)
{
    cout << "車のナンバーは" << pC -> num << "ガソリン量は" << "pc -> gas << "です。\n";   //ポインタからメンバにアクセスします。
}

int main()
{
    Car car1 = {0, 0.0};

    cout << "ナンバーを入力して下さい。\n";
    cin >> car1.num;

    cout << "ガソリン量を入力して下さい。\n";
    cin >> car1.gas;

    show(&car1);   //構造体car1のアドレスを渡します。

    return 0;
}