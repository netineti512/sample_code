//構造体を関数の引数として使う
#include<iostream>
using namespace std;

//構造体型Carの宣言
struct Car{
    int num;
    double gas;
};

//show関数の宣言
void show(Car c);   //構造体を引数に持つ関数です。

//show関数の定義
void show(Car c)
{
    cout << "車のナンバーは" << c.num << "ガソリン量は" << c.gas << "です。\n";   //出力します。
}

int main()
{
    Car car1 = {0, 0.0};

    cout << "ナンバーを入力して下さい。\n";
    cin >> car1.num;

    cout << "ガソリン量を入力して下さい。\n";
    cin >> car1.gas;

    show(car1);   //構造体car1(の値)を渡します
    return 0;
}