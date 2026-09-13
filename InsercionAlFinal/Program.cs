int[] arr = {11, 21, 31, 41, 51, 61};
int Elemento = 1;

Console.WriteLine("Antes de la insercion, el array es: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}


int[] arrdos = new int[arr.Length + 1];
for (int i = 0; i < arr.Length; i++)
{
    arrdos[i] = arr[i];
}
    arrdos[arr.Length] = Elemento;
Console.WriteLine("\nDespues de la insercion, el array es: ");
for (int i = 0; i < arrdos.Length; i++) 
{
    Console.Write(arrdos[i] + " ");
}