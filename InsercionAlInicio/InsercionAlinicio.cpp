#include <iostream>
using namespace std;

    int main() {
        int arr[] = {11, 21, 31, 41, 51, 61};
        int arreglo = sizeof(arr) / sizeof(arr[0]);
        int Elemento = 13;
        cout << "Antes de la insercion, el array es: " << endl;
        for (int i = 0; i < 6; i++) 
        {
            cout << arr[i] << " ";
        }

        int arrdos[arreglo+1];
        arrdos[0] = Elemento;
        for (int i = 0; i < arreglo; i++) 
        {
            arrdos[i + 1] = arr[i];
        }
        cout << "\nDespues de la insercion, el array es: " << endl;
        for (int i = 0; i < arreglo + 1; i++)
        {
            cout << arrdos[i] << " ";
        }

        return 0;


    }