#include <iostream>
using namespace std;

int FindEle(int Arr[], int l, int h, int TargetValue)
{
    while (l<= h)
    {
        int mid = l + (h-l)/2;
        if (Arr[mid] == TargetValue)
        {
            return mid;
        }
        else if (Arr[mid] < TargetValue)
        {
            l = mid + 1;
        }
        else
        {
            h = mid - 1;
        }
    }
    return -1;

}
int main()
{
    int InPutArr[]= {6, 10, 12, 19, 34, 40, 57, 69, 89, 98};
    int TargetElement = 98;
    int s = sizeof(InPutArr)/sizeof(InPutArr[0]);
    int idx = FindEle(InPutArr, 0, s-1, TargetElement);
    if (idx != -1)
    {
        cout << "El elemento se encuentra en la posicion: " << (idx+1) << endl;
    }
    else
    {
        cout << "El elemento no se encuentra" << endl;

    }


}