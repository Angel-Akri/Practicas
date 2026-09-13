{
     int[] arr= {40, 50, 60, 70, 80, 90};
        
     Console.Write("Los elementos del array son: ");

    for (int idx = 0; idx < arr.Length; idx++) 
    //va a ir sumando 1 para cada ciclo hasta que se acabe el array para imprimirlo
    {
        Console.Write(arr[idx] + " ");
    }
}