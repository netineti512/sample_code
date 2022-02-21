//オブジェクトのクラスを調べる
#include<iostream>
#include<typeinfo>   //<tpeinfo>ヘッダをインクルードします。
using namespace std;

//Vehicleクラスの宣言
class Vehicle {  //抽象クラスです。
protected:
	int speed;
public:
	void setSpeed(int s);
	virtual void show() = 0;  //純粋仮想関数show()です。
};

//Carクラスの宣言
class Car : public Vehicle {   //抽象クラスから派生しました。

private:
	int num;
	double gas;
public:
	Car(int n, double g);
	void show();   //show()メンバ関数を持ちます。
};

//Planeクラスの宣言
class Plane : public Vehicle {   //抽象クラスから派生しました。
private:
	int flight;
public:
	Plane(int f);
	void show();   //show()メンバ関数を持ちます。
};

//Vehicleクラスメンバ関数の定義
void Vehicle::setSpeed(int s)
{
	speed = s;
	cout << "速度を" << speed << "にしました。\n";
}

//Carクラスメンバの定義
Car::Car(int n, double g)
{
	num = n;
	gas = g;
	cout << "ナンバー" << num << "、ガソリン量" << gas << "の車を作成しました。\n";
}
void Car::show()
{
	//show()メンバ関数の処理を定義しました。
	cout << "車のナンバーは" << num << "です、\n";
	cout << "ガソリン量は" << gas << "です。\n";
	cout << "速度は" << speed << "です、\n";
}

//Planeクラスメンバ関数の定義
Plane::Plane(int f)
{
	flight = f;
	cout << "便" << flight << "の飛行機を作成しました。\n";
}
void Plane::show()
{
	//show()メンバ関数の処理を定義しました。
	cout << "飛行機の便は" << flight << "です。\n";
	cout << "速度は" << speed << "です。\n";
}

int main()
{
	Vehicle* pVc[2];
	Car car1(1234, 20.5);
	Plane pln1(232);

	pVc[0] = &car1;   //1つ目のオブジェクトはCarクラスです。
	pVc[1] = &pln1;   //2つ目のオブジェクトはPlaneクラスです。

	for (int i = 0; i < 2; i++)
	{
		if (typeid(*pVc[i]) == typeid(Car))   //クラスがおなしであるかを調べます。
		{
			cout << (i + 1) << "番目は" << typeid(Car).name() << "です。\n";
		}
		else
		{
			cout << (i + 1) << "番目は" << typeid(Car).name() << "ではありません。" << typeid(*pVc[i]).name() << "です。\n";   //クラス名を調べます。
		}
	}
}