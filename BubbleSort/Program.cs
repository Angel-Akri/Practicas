using System;

class BubbleSort
{
    static void Bubblesort(int[] a)
    {
        int s;
        int i;
        int j;
        bool isSwapped;
        int temporal; //guarda el valor de a[j] sin perder el valor original
        s = a.Length;
        for (i = 0; i < s; i++)
        {
            isSwapped = false;
            for (j = 0; j < s - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    temporal = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temporal;
                    isSwapped = true;
                }
            }
            if (!isSwapped) break;
        }
    }
    static void Main(string[] args)
    {
        int[] a = { 15, 16, 11, 13, 14 };
        Console.WriteLine("Antes de ordenar los elementos del array son: ");
        foreach (int j in a)
        {
            Console.Write(j + " ");
        }
        Bubblesort(a);
        Console.WriteLine("\nDespues de ordenar los elementos del array son: ");
        for (int j = 0; j < a.Length; j++)
        {
            Console.Write(a[j] + " ");
        }
    }
}