class Program
{
    static int FindEle(int[] Arr, int l, int h, int TargetValue)
    {
        while (l <= h)
        {
            int mid = l+(h-l)/2;
            if (Arr[mid] == TargetValue)
            {
                return mid;
            }
            else if (Arr[mid] < TargetValue)
            {
                l = mid+1;
            }
            else
            {
                h = mid-1;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] InPutArr={6, 10, 12, 19, 34, 40, 57, 69, 89, 98};
        int TargetElement = 69;
        int s= InPutArr.Length;
        int idx= FindEle(InPutArr, 0, s-1, TargetElement);
        if (idx != -1)
        {
            Console.WriteLine("El elemento se encuentra en la posicion: " + (idx+1));
        }
        else
        {
            Console.WriteLine("El elemento no se encontro");
        }
    }
}
