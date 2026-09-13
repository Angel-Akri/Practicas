public class RecorridoSecuencial
{
    public static void main(String[] args)
    {
        int arr[]={40, 50, 60, 70, 80, 90};
        int arrelo=arr.length;
        System.out.println("Los elementos del array son: ");
        for(int idx = 0; idx < arrelo; idx++)
        {
            System.out.print(arr[idx]+" ");
        }
    }
}