//配列で文字列を操作する
#include<iostream>
using namespace std;

int main()
{
    char str[] = "Hello";
    
    cout << "Hello\n";
    
    for (int i = 0; str[i] != '\0'; i++)   //\0でない限り繰り返します。
    {
        cout << str[i] << "*";
    }
    cout << "\n";
    
    return 0;
}