//標準ライブラリのstrcpy()関数を使う
#include<iostream>
#include<cstring>
using namespace std;

int main()
{
    char str0[20];
    char str1[10];
    char str2[10];
    
    strcpy(str1, "Hello");      //str1[]に"Hello"をコピーします。
    strcpy(str2, "GoodBye");    //str2[]に"GoodBye"をコピーします。
    strcpy(str0, str1);         //str0[]にstr1[]をコピーします。
    strcat(str0, str2);         //str0[]の末尾にstr2[]を追加します。
    
    return 0;
}