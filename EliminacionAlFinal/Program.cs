using System.Collections.Generic;

List<int> arr=new List<int>{11, 21, 31, 41, 51, 61, 71, 81, 91};
//List<int> deine el tipo de dato
//new reserva la memoria   
Console.WriteLine("Antes de la eliminacion, el array es: ");
foreach (int i in arr) 
    {
        Console.Write(i+" ");
    }

arr.RemoveAt(arr.Count - 1);
Console.WriteLine("\nDespues de la eliminacion, el array es: ");
foreach (int i in arr)
    {
        Console.Write(i+" ");
    }