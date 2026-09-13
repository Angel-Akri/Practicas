public class BusquedaSecuencial
{
    public static int EncontrarEle(int[]arr, int i, int Elemento)
    {
        for (int j=0; j < i; j++)
            {
                if (arr[j] == Elemento)
                    {
                        return j;
                    }
            }
        return -1;

    }

public static void main(String[] args) 
    {
    int[] arr= {12, 34, 10, 6, 40, 89, 98, 57, 19, 69};
    int elemento = 69;
    int i = arr.length;
    int idx = EncontrarEle(arr, i, elemento);

        if (idx != -1)
        {
            System.out.println("El elemento se encuentra en la posicion: " + (idx + 1));
        }
        else
        {
            System.out.println("No se encuentra el elemento.");
        }
    }

}