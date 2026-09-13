#include <iostream>
using namespace std;
int main(){

    int arr[] = {40, 50, 60, 70, 80, 90};
    int array = sizeof(arr) / sizeof(arr[0]);

    cout << "Los elementos del array son: " << endl;

    for (int idx = 0; idx < array; idx++)
    {
        cout << arr[idx] << " ";
    }
    return 0;
}