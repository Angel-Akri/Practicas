using System.Collections.Generic;

List<int> arr=new List<int>{11, 21, 31, 41, 51, 61};
//List<int> deine el tipo de dato
//new reserva la memoria   
Console.WriteLine("Antes de la eliminacion, el array es: ");
foreach (int i in arr) 
    {
        Console.Write(i+" ");
    }

int idxEliminado = 3;
arr.RemoveAt(idxEliminado);
Console.WriteLine("\nDespues de la eliminacion, el array es: ");
foreach (int i in arr)
    {
        Console.Write(i+" ");
    }