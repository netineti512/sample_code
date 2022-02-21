//配列名から先頭要素の値を知る
#include<iostream>
using namespace std;

int main()
{
    int test[5] = {80, 60, 55, 22, 75};
    
    cout << "test[0]の値は" << test[0] << "です。\n";
    cout << "test[0]のアドレスは" << &test[0] << "です。\n";   //配列先頭要素のアドレスを使って知ることができます。
    cout << "testの値は" << test << "です。\n";     //「配列名」でも先頭要素のアドレスをあらわします。
    cout << "つまり*testの値は" << *test << "です。\n";   //つまり*testで配列の先頭要素をあらわせます。
    
    return 0;
}