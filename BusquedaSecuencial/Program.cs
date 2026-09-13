using System;
class Program
{
    static int EncontrarEle(int[] arr, int i, int Elemento)
    {
        for (int j = 0; j < i; j++)
        {
            if (arr[j] == Elemento)//Verifica que ell elemento sea el correcto
            {
                return j; // guarda el elemento encontrado en j
            }
        }
        return -1; // No encontro el elemento
    }

    static void Main()
    {
        int[] arr = { 12, 34, 10, 6, 40, 89, 98, 57, 19, 69};
        int Elemento = 98;
        int i = arr.Length;
        int idx = EncontrarEle(arr, i, Elemento);

        if (idx !=-1)
        {
            Console.WriteLine("El elemento se encuentra en la posicion:" + (idx+1));
        }
        else
        {
            Console.WriteLine("No se encuentra el elemento");
        }
    }
}