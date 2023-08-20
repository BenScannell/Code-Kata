#include <vector>
#include <iostream>
using namespace std;
//find and return the "odd number out" in a vector
float find_uniq(const std::vector<float>& v)
{
    float number;
    float odd1;
    float odd2;
    float compare = v[0];
    int y = v.size();
    int b = 0;
    int a = 0;
    for(int x = 0; x < y; x++) 
    {
        number = v[x];
        if (number != compare) 
        {
            b++;
            odd1 = number;
        }
        else
        {
            a++;
            odd2 = number;
        }
    }
    return (a > b) ? odd1 : odd2;
}
int main()
{
    float result = find_uniq(std::vector<float>{999.666, 999.666, 999.666, 999.666, 999.666, 999.666, 999.666, 999, 999.666});
    cout << result;
}