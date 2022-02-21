//列挙型の変数を使う
#include<iostream>
using namespace std;

//列挙型Weekの宣言
enum Week {SUN, MON, TUE, WED, THU, FRI, SAT};   //列挙型を宣言します。

int main()
{
    Week w;   //Week型の変数wを宣言します。
    w = SUN;  //値SUNを代入します。

    //値により異なる出力を行います。
    switch (w) {
        case SUN: cout << "日曜です。\n"; break;
        case MON: cout << "月曜です。\n"; break;
        case TUE: cout << "火曜です。\n"; break;
        case WED: cout << "水曜です。\n"; break;
        case THU: cout << "木曜です。\n"; break;
        case FRI: cout << "金曜です。\n"; break;
        case SAT: cout << "土曜です。\n"; break;
        default:  cout << "何曜日だかわかりません。\n"; break;
    }

    return 0;
}