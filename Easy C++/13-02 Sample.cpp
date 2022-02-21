//コンストラクタをオーバーロードする
#include<iostream>
using namespace std;

//Carクラスの宣言
class Car{
    private:
        int num;
        double gas;
    public:
        Car();
        Car(int n, double g);
        void show();
};

//Carクラスメンバ関数の定義
Car::Car()     //引数のないコンストラクタです。
{
    num = 0;
    gas = 0.0;
    cout << "車を作成しました。\n";
}
Car::Car(int n, double g)     //引数を2個もつコンストラクタです。
{
    num = g;
    gas = g;
    cout << "ナンバー" << num << "、ガソリン量" << gas << "の車を作成しました。\n";
}
void Car::show()
{
    cout << "車のナンバーは" << num << "です。\n";
    cout << "ガソリン量は" << gas << "です。\n";
}

int main()
{
    Car car1;   //引数のないコンストラクタが呼び出されます。
    Car car2(1234, 20.5);   //引数を2個もつコンストラクタが呼び出されます。

    return 0;
}