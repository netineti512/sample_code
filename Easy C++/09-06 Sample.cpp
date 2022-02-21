//ポインタの演算をする
#include<iostream>
using namespace std;

int main()
{
    int test[5] = {80, 60, 55, 22, 75};
    
    cout << "test[0]の値は" << test[0] << "です。\n";
    cout << "test[0]のアドレスは" << &test[0] << "です。";
    cout << "testの値は" << test << "です。\n";
    cout << "(test + 1)の値は" << test + 1 << "です。\n";    //先頭要素の「次の」要素のアドレスを表します。
    cout << "*(test + 1)の値は" << *(test + 1) << "です。\n";   //先頭要素の「次の」要素の値を表します。
    
    return 0;
}