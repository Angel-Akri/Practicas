#include <vector>
#include <iostream>
using namespace std;

int main()
{
 vector<int> arr = {11, 21, 31, 41, 51, 61};
 cout << "Antes de la eliminacion, el array es: " << endl;
 for (size_t i = 0; i < arr.size(); i++)
    {
        cout << arr[i] << " ";
    }
//size_t es un dato entero sin numeros negativos
int idxEliminado = 4;
arr.erase(arr.begin() + idxEliminado); //Ahora borra el indice marcado
cout << "\nDespues de la eliminacion, el array es: " << endl;
for (size_t i = 0; i < arr.size(); i++)
    {
        cout << arr[i] << " ";
    }

    return 0;

}