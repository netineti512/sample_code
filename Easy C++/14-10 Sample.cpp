//仮想基本クラスとして継承する
#include<iostream>
using namespace std;

//Base0クラスの宣言
class Base0 {
protected:
	int bs0;
public:
	Base0(int b0 = 0) { bs0 = b0; }
	void showBs0();
};

//Base0クラスメンバ関数の定義
void Base0::showBs0()
{
	cout << "bs0は" << bs0 << "です。\n";
}

//Base1クラスの宣言
class Base1 : public virtual Base0 {   //Base0()を仮想基本クラスとして継承します。
protected:
	int bs1;
public:
	Base1(int b1 = 0) { bs1 = b1; }
	void showBs1();
};

//Base1クラスメンバ関数の定義
void Base1::showBs1()
{
	cout << "bs1は" << bs1 << "です。\n";
}

//Base2クラスの宣言
class Base2 : public virtual Base0 {   //Base0を仮想基本クラスとして継承します。
protected:
	int bs2;
public:
	Base2(int b2 = 0) { bs2 = b2; }
	void showBs2();
};

//Base2クラスメンバ関数の定義
void Base2::showBs2()
{
	cout << "bs2は" << bs2 << "です。\n";
}

//Derivedクラスの宣言
class Derived : public Base1, public Base2 {   //2つのクラスから派生しています。
protected:
	int dr;
public:
	Derived(int d = 0) { dr = d; }
	void showDr();
};

//Derivedクラスメンバ関数の定義
void Derived::showDr()
{
	cout << "drは" << dr << "です。\n";
}

int main()
{
	Derived drv;
	
	drv.showBs0();     //仮想基本クラスから継承されたメンバを呼び出すことができます。

	return 0;
}