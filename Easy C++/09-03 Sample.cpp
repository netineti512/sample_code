///配列の要素をソートする
#include<iostream>
using namespace std;

int main()
{
    const int num = 5;
    int test[num];
    
    cout << num << "人の点数を入力して下さい。\n";
    for (int i = 0; i < num; i++)
    {
        cin >> test[i];
    }
    
    //配列をソートしています。
    for (int s = 0; s < num - 1; s++)
    {
        for(int t = s+1; t < num; t++)
        {
            if (test[t] > test[s])
            {
                int tmp = test[s];
                test[s] = test[t];
                test[t] = tmp;
            }
        }
    }
    
    for (int j = 0; j < num; j++)
    {
        cout << j + 1 << "番目の人の点数は" << test[j] << "です。\n";
    }
    
    return 0;
}