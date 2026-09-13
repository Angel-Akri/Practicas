public class InserccionAlFinal 
{
    public static void main(String[] args) 
    {
    int arr[] = {11, 21, 31, 41, 51, 61};
    int elemento = 22;

    System.out.println("Antes de la insercion, el array es: "); 
    for(int i = 0; i < arr.length; i++)
    {
        System.out.print(arr[i] + " ");
    }
    System.out.println();
    

    int arrdos[] = new int[arr.length + 1];
    for (int i = 0; i < arr.length; i++)
    {
        arrdos[i] = arr[i];
    }
     arrdos[arrdos.length - 1] = elemento;
    
    System.out.println("Despues de la insercion, el array es: ");
    for (int j = 0; j< arrdos.length; j++)
    {
        System.out.print(arrdos[j]+ " ");
    }
    }

}