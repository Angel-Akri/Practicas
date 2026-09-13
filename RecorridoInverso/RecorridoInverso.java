public class RecorridoInverso
{
    public static void main(String[] args)
    {
        int arr[]={40, 50, 60, 70, 80, 90};
        int arreglo=arr.length;
        System.out.println("Los elementos del array son: ");
        for(int idx = arreglo - 1; idx >= 0; idx--)
        {
            System.out.print(arr[idx]+" ");
        }
    }
}