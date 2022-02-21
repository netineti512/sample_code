//デフォルト引数をもつコンストラクタを利用する
#include<iostream>
using namespace std;

//Carクラスの宣言
class Car{
    private:
        int num;
        double gas;
    public:
        Car(int n = 0, double g = 0);   //デフォルト引数を持つコンストラクタです。
        void show();
};

//Carクラスメンバ関数の定義
Car::Car(int n, double g)
{
    num = n;
    gas = g;
    cout << "ナンバー" << num << "ガソリン量" << gas << "の車を作成しました。\n";
}
void Car::show()
{
    cout << "車のナンバーは" << num << "です。\n";
    cout << "ガソリン量は" << gas << "です。\n";
}

int main()
{
    Car car1;   //引数を渡さないでオブジェクトを作成します。
    Car car2(1234, 20.5);   //引数を渡してオブジェクトを作成します。

    return 0;
}