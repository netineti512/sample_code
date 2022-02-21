//デフォルトコンストラクタを用意する
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

//初期化子なしで配列を作成するには、引数のないコンストラクタが必要です。
//Carクラスメンバ関数の定義
Car::Car()

{
    num = 0;
    gas = 0.0;
    cout << "車を作成しました。\n";
}
Car::Car(int n, double g)
{
    num = n;
    gas = g;
    cout << "ナンバー" << num << "、ガソリン量" << gas << "の車を作成しました。\n";
}
void Car::show()
{
    cout << "車のナンバーは" << num << "です。\n"
    cout << "ガソリン量は" << gas << "です。\n";
}

int main()
{
    Car cars[3];   //引数のないコンストラクタが呼び出されます。

    return 0;
}