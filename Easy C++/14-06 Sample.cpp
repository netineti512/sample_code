//抽象クラスを利用する
#include<iostream>
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
	Vehicle* pVc[2];   //抽象クラスへのポインタの配列を準備します。

	Car car1(1234, 20.5);
	pVc[0] = &car1;   //1番目のオブジェクトはCarクラスです。
	pVc[1]->setSpeed(500);

	for (int i = 0; i < 2; i++) {
		pVc[i]->show();   //show()メンバ関数を呼び出すと、
	}
}