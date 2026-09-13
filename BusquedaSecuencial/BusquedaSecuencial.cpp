#include <iostream>
using namespace std;

int EncontrarEle(int arr[], int i, int Elemento)
{
    for (int j=0; j < i; j++)
    {
        if(arr[j] == Elemento)
        {
            return j;
        }
    }
    return -1;
}

int main()
{
    int arr[]= {12, 34, 10, 6, 40, 89, 98, 57, 19, 69};
    int Elemento = 12;
    int i= sizeof(arr)/sizeof(arr[0]);
    int idx = EncontrarEle(arr, i, Elemento);
    if (idx != -1)
    {
        cout << "El elemento se encuentra en la posicion: " << (idx +1)<< endl;
    }
    else
    {
        cout << "No se encuentra el elemento." << endl;
    }



}