//共用体型を使う
#include<iostream>
using namespace std;

//共用体型を宣言します
//共用体型Yearの宣言
union Year{
    int ad;
    int gengo;
};

int main()
{
    Yera myyear;   //共用体型の変数を宣言します。

    cout << "西暦を入力して下さい。\n";
    cin >> myyear.ad;   //myyearのメンバadに値を格納すると、

    cout << "西暦は" << myyear.ad << "です。\n";
    cout << "元号も" << myyear.gengo << "です。\n;   //メンバgengoも同じ値になります。

    cout << "元号を入力して下さい。\n";
    cin >> myyear.gengo;

    cout << "元号は" << myyear.gengo << "です。\n";
    cout << "西暦も" << myyear.ad << "です。\n";

    return 0;
}