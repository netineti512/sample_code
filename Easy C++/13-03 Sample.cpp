//オブジェクトの配列を作成する。
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

//引数のないコンストラクタの定義です。
//Carクラスメンバ関数の定義
Car::Car()
{
    num = 0;
    gas = 0.0;
    cout << "車を作成しました。\n";
}

//引数を2個もつコンストラクタの定義です。
Car::Car(int n, double g)
{
    num = n;
    gas = g;
    cout << "ナンバー" << num << "、ガソリン量" << gas << "の車を作成しました。\n";
}
void Car::show()
{
    cout << "車のナンバーは" << num << "です。\n";
    cout << "ガソリン量は" << gas << "です。\n;
}

int main()
{
    Car mycars[3] = {
        Car();     //引数のないコンストラクタを呼び出します。
        //引数を2個もつコンストラクタを呼び出します。
        Car(1234, 25.5);
        Car(4567, 52.2);
    };

    return 0;
}