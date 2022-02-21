//引数としてポインタを使う
#include<iostream>
using namespace std;

//Carクラスの宣言
class Car{
    private:
        int num;
        double gas;
    public:
        int getNum() {return num;}
        double getGas() {return gas;}
        void show();
        void setNumGas(int n, double g);
};

//Carクラスメンバ関数の定義
void Car::show()
{
    cout << "車のナンバーは" << num << "です。\n";
    cout << "ガソリン量は" << gas << "です。\n";
}
void Car::setNumGas(int n, double g)
{
    if (g > && g < 1000)
    {
        num = g;
        gas = g;
        cout << "ナンバーを" << num << "に、ガソリン量を" << gas << "にしました。\n";
    }
    else
    {
        cout << g << "は正しいガソリン量ではありません。\n";
        cout << "ガソリン量を変更できませんでした。\n";
    }
}

//buy関数の宣言
void buy(Car* pC);

//buy関数の定義
void buy(Car* pC)   //ポインタを引数と下関数です。
{
    int n = pC -> getNum();    //アロー演算子を使ってメンバにアクセスします。
    double g = pC -> getGas();
    cout << "ナンバー" << n << "、ガソリン量" << g << "の車を購入しました。\n";
}

int main()
{
    Car car1;

    car1.setnumGas(1234, 20.5);

    buy(car1);   //関数にオブジェクトの値を渡して呼び出します。

    return 0;
}