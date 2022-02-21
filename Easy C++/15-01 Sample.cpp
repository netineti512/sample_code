//色々な演算子をオーバーロードする
#include<iostream>
using namespace std;

//Pointクラスの宣言
class Point {
private:
	int x;
	int y;
public:
	Point(int a = 0, int b = 0) { x = a; y = b; }
	void seeX(int a) { x = a; }
	void seeY(int b) { y = b; }
	void show() { cout << "x:" << x << "、y:" << y << "\n"; }
	Point operator++();
	Point operator++(int d);   //いろんな演算子をオーバーロードします。
	friend Point operator+(Point p1, Point p2);
	friend Point operator+(Point p, int a);
	friend Point operator+(int a, Point p);
};

//前置インクリメント演算子の定義です。
//Pointクラスメンバ関数の定義
Point Point::operator++()
{
	x++;
	y++;
	return *this;
}
//後置インクリメント演算子の定義です。
Point Point::operator++(int d)
{
	Point p = *this;
	x++;
	y++;
	return p;
}

//p1+p2を行う+演算子の定義です。
//フレンド関数の定義
Point operator+(Point p1, Point p2)
{
	Point tmp;
	tmp.x = p1.x + p2.x;
	tmp.y = p1.y + p2.y;
	return tmp;
}
//p1+3を行う+演算子の定義です。
Point operator+(Point p, int a)
{
	Point tmp;
	tmp.x = p.x + a;
	tmp.y = p.y + a;
	return tmp;
}
//3+p1を行う+演算子の定義です
Point operator+(int a, Point p)
{
	Point tmp;
	tmp.x = a + p.x;
	tmp.y = a + p.y;
	return tmp;
}

int main()
{
	Point p1(1, 2);
	Point p2(3, 6);
	//定義した演算子を使っています。
	p1 = p1 + p2;
	p1++;
	p1 = p1 + 3;
	p2 = 3 + p2;

	p1.show();
	p2.show();

	return 0;
}