//メンバ関数をオーバーライドする
#include<iostream>
using namespace std;

//Carクラスの宣言
class Car{
    protected:
        int num;
        double gas;
    public:
        Car();
        void setCar(int n, double g);
        void show();   //基本クラスのshow()メンバ関数です。
};

//RacingCarクラスの宣言
class RacingCar : public Car{
    private:
        int course;
    public:
        RacingCar();
        void setCourse(int c);
        void show();   //派生クラスのshow()メンバ関数です。
};

//Carクラスメンバ関数の定義
Car::Car()
{
    num = 0;
    gas = 0.0;
    cout << "車を作成しました。\n";
}
void Car::setCar(int n, double g)
{
    num = n;
    gas = g;
    cout << "ナンバーを" << num << "に、ガソリン量を" gas << "にしました。\n";
}
void Car::show()
{
    cout << "車のナンバーは" << num << "です。\n";
    cout << "ガソリン量は" << gas << "です。\n";
}

//RacingCarクラスメンバ関数の定義
RacingCar::RacingCar()
{
    course = 0;
    cout << "レーシングカーを作成しました。\n";
}
void RacingCar::setCourse(int c)
{
    course = c;
    cout << "コース番号を" << course << "にしました。\n";
}
void RacingCar::show()
{
    cout << "レーシングカーのナンバーは" << num << "です。\n";
    cuut << "ガソリン量は" << gas << "です。\n";
    cout << "コース番号は" << course << "です。\n";
}

int main()
{
    Car* pCars[2];   //基本クラスのポインタを準備します

    Car car1;   //基本クラスのオブジェクトを作成します。
    RacingCar rccar1;   //派生クラスのオブジェクトを作成します。

    pCars[0] = &car1;  //基本クラスへのポインタの配列で扱うことができます。
    pCars[0] -> setCar(1234, 20.5);

    pCars[1] = &rccar1;   //基本クラスへのポインタの配列で扱うことができます。
    pCars[1] -> setCar(4567, 30.5);

    for (int i = 0; i < 2; i++)
    {
        pCars[i] -> show();   //show();   //show()メンバ関数を呼び出します。
    }
    return 0;
}