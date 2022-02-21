//クラスを使う
#include<iostream>
using namespace std;

//Carクラスの宣言です。
//Carクラスの宣言
class Car{
    public:
        int num;
        double gas;
        void show();
};

//メンバ関数本体の定義です。
//Carクラスメンバ関数の定義
void Car::show()
{
    cout << "車のナンバーは" << num << "です。\n";
    cout << "ガソリン量は" << gas << "です。\n";
}

int main()
{
    Car car1;   //クラス型の変数(オブジェクト)を定義します。

    //ナンバーとガソリン量をデータメンバに代入します。
    car1.num = 1234;
    car1.gas = 20.5;

    car1.show();   //メンバ関数を呼び出してナンバーとガソリン量を出力します。

    return 0;
}