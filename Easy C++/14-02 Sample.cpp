//基本クラスのコンストラクタ
#include<iostream>
sing namespace std;

//Carクラスの宣言
class Car{
    private:
        int num;
        double gas;
    public:
        Car();
        Car(int n, double g);
        void setCar(int n, double g);
        void show();
};

//RacingCarクラスの宣言
class Racing : public Car{
    private:
        int course;
    public:
        RacingCar();
        RacingCar(int n, double g, int c);
        void setCoruse(int c);
};

//Carクラスメンバ関数の定義
Car::Car()
{
    num = 0;
    gas = 0.0;
    cout << "車を作成しました。\n";
}
//Carクラスメンバ関数の定義です
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
    cout << "ナンバー" << num << "、ガソリン量" << gas << "の車を車を作成しました。\n";
}
void Car::setCar(int n, double g)
{
    num = n;
    gas = g;
    cout << "ナンバーを" << num << "に、ガソリン量を" << gas << "にしました。\n";
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
RacingCar::RacingCar(int n, double g, int c) : Car(n, g)   //基本クラスの引数2個のコンストラクタが呼び出されるようにします。
{
    course c;
    cout << "コース番号" << course << "のレーシングカーを作成しました。\n";
}
void RacingCar::setCourse(int c)
{
    course = c;
    cout << "コース番号を" course << "にしました。\n";
}

int main()
{
    Racing rccar(1234, 20.5, 5);  //派生クラスの引数3個のコンストラクタが呼び出されるようにします。

    return 0;
}