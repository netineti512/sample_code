//構造体のメンバにアクセスする
#include<iostream>
using namespace std;

//構造体型を宣言します。
//構造体型Carの宣言
struct Car{
    int num;
    double gas;
};

int main()
{
    Car car1;   //構造体型の変数を宣言します。

    cout << "ナンバーを入力して下さい。\n";
    cin >> car1.num;   //メンバに値を代入します。

    cout << "ガソリン量を入力して下さい。\n";
    cin >> car1.gas;

    cout << "車のナンバーは" << car1.num << "、ガソリン量は" << car1.gas << "です。\n";   //メンバの値を出力します。

    return 0;
}