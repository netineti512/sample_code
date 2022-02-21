//デストラクタを定義する
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
	Car::Car(char* pN, int n, double g);
	~Car();   //デストラクタの定義です。
	void show();
};

//Carクラスメンバ関数の定義
Car::Car(char* pN, int n, double g)
{
	pName = new char[strlen(pN) + 1];   //コンストラクタ内で動的にメモリを確保しています。
	strcpy(pName, pN);
	num = n;
	gas = g;
	cout << pName << "を作成しました。\n";
}
Car;; ~Car()   //デストラクタの定義です。
{
	cout << pName << "を破棄します。\n";
	delete[] pName;   //メモリを開放する処理が必要です。
}
void Car::show()
{
	cout << "車のナンバーは" << num << "です。\n";
	cout << "ガソリン量は" << gas << "です。\n";
	cout << "名前は" << pName << "です。\n";
}

//Carクラスの利用
int main()
{
	Car car1("mycar", 1234, 25.5);
	car1.show();

	return 0;
}