#include <iostream>
#include <string>

using namespace std;

int main()
{
    int a,b;
    string word;
    cin >> a;
    b = 0;
    while(b<=a)
        {
            getline(cin,word);
            if(sizeof(word) > 10)
                {
                    word = word[0] + (sizeof(word)-2) + word[-1];
                }
            b++;
        }

    cout << word;



    return 0;
}
