//こぴーコンストラクタ・代入演算子のオーバーロード
#include<iostream>
#include<cstring>
using namespace std;

//Carクラスの宣言
class Car {
private:
	int num;
	double gas;
	char* pName;
public:
	Car(char* pN, int n, double g);
	~Car();
	Car(const Car& c);   //コピーコンストラクタの宣言です。
	Car& operator=(const Car& c);   //代入演算子の宣言です。
};

//Carクラスメンバ関数の定義です
Car::Car(char* pN, int n, double g)
{
	pName = new char[strlen(pN) + 1];   //コンストラクタ内で動的にメモリを確保しています。
	strcpy(pName, pN);
	num = n;
	gas = g;
	cout << pName << "を作成しました。\n";
}
Car::~Car()
{
	cout << pName << "を破棄します。\n";   //デストラクタ内でメモリを開放します。
	delete[] pName;
}
Car::Car(const Car& c)   //コピーコンストラクタです。
{
	cout << c.pName << "で初期化します。\n";
	pName = new char[strlen(c.pName) + strlen("のコピー1") + 1];
	strcpy(pName, c.pName);
	strcat(pName, "のコピー1");
	num = c.num;
	gas = c.gas;
}
Car& Car::operator=(const Car& c)   //代入演算子のオーバーロードです。
{
	cout << pName << "に" << c.pName << "を代入します。\n";
	if (this != &c) {
		delete[] pName;
		pName = new char[strlen(c.pName) + strlen("のコピー2") + 1];
		strcpy(pName, c.pName);
		strcat(pName, "のコピー2");
		num = c.num;
		gas = c.gas;
	}
	return *this;
}

int main()
{
	Car mycar("mycar", 1234, 25.5);

	Car car1 = mycar;   //初期化しています。

	Car car2("car2", 0, 0);
	car2 = mycar;   //代入しています。

	return 0;
}