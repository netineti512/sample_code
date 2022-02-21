//メンバへのアクセスを制限する
#include<iostream>
using namespace std;

//データメンバはprivateにしました。
//メンバ関数はpublicにしました。
class Car{
    private:
        int num;
        double gas;
    public:
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
    if (g > 0 && g < 1000)    //渡された値を調べて、正しければ値を設定します。
    {
        num = n;
        gas = g;
        cout << "ナンバを" << num << "にガソリン量を" << gas << "にしました。\n";
    }
    else
    {
        //誤った値を設定できないようにしています。
        cout << g << "は正しいガソリン量ではありません。\n";
        cout << "ガソリン量を変更できませんでした。\n";
    }
}

int main()
{
    Car car1;

    //privateメンバにはアクセスできません。
    //このようなアクセスはできなくなります。
    //car1.num = 1234;
    //car1.gas = 20.5;

    car1.setNumGas(1234, 20.5);    //必ずpublicメンバを呼び出して値を設定します。
    car.show();

    cout << "正しくないガソリン量を(-10.0)を指定してみます。。。\n";
    car1.setNumGas(1234, -10.0);
    car1.show();

    return 0;
}