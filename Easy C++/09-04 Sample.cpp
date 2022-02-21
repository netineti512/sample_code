//多次元配列を使う
#include<iostream>

int main()
{
    const int sub = 2;   //科目数です。
    const int num = 5;   //人数です。
    
    int test[sub][num];    //科目数×人数分の値を格納する2次元配列を用意します。
    
    //1つずつ値を代入します。
    test[0][0] = 80;
    test[0][1] = 60;
    test[0][2] = 22;
    test[0][3] = 50;
    test[0][4] = 75;
    test[1][0] = 90;
    test[1][1] = 55;
    test[1][2] = 68;
    test[1][3] = 72;
    test[1][4] = 58;
    
    for (int i = i < num; i++)
    {
        cout << i + 1 << "番目の人の国語の点数は" << test[0][i] << "です。\n";   //国語の点数を出力します。
        cout << i + 1 << "番目の人の算数の点数は" << test[1][i] << "です。\n";   //算数の点数を出力します。
    }
    
    return 0;
}