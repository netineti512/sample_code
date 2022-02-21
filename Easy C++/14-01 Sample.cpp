//クラスを拡張する
#include<iostream>
using namespace std;

//基本クラスの宣言です。
//Carクラスの宣言
class Car{
    private:
        int num;
        double gas;
    public:
        Car();
        void setCar(int n, double g);
        void show();
};

//RacingCarクラスの宣言
class RacingCar : public Car{    //派生クラスの宣言です。
    private:
        int course;     //追加するデータメンバです。
    public:
        RacinCar();     //派生クラスのコンストラクタです。
        void setCourse(int c);    //追加するメンバ関数です。
};

//Carクラスメンバ関数の定義
Car::Car()
{
    num = 0;
    gas = 0.0;
    cout << "車を作成しました。\n";
}
void Car::setCar(int n, double g);
{
    num = n;
    gas = g;
    cout << "なんばーを" << num << "にガソリン量を" << gas << "にしました。\n";
}
void Car::show()
{
    cout << "車のナンバーは" << num << "です。\n";
    cout << "ガソリン量は" << gas << "です。\n";
}

//RacingCarクラスメンバ関数の定義
RacingCar::RacingCar()
{
    course = c;
    cout << "コース番号を" << course << "にしました。\n";
}

int main()
{
    RacingCar rccar1;   //派生クラスのオブジェクトを作成します。
    rccar1.setCar(1234, 20.5);   //継承したメンバ関数を呼び出しています。
    rccar1.setCourse(5);     //追加したメンバ関数を呼び出しています。

    return 0;
}