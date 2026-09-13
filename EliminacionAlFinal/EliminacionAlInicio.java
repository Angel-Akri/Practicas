import java.util.ArrayList;
import java.util.List;

public class EliminacionAlInicio 
{
    public static void main (String[] args)
    {
        List<Integer> arr = new ArrayList<>(List.of(11, 21, 31, 41, 51, 61, 71, 81, 91, 101, 111));
        System.out.println("Antes de la eliminacion, el array es:");
        for (int i:arr)
        {
            System.out.print(i+" ");
        }
     
    
        arr.remove(arr.size()-1);
        System.out.println("\nDespues de la eliminacion, el array es:");
        for (int i:arr)
        {
        System.out.print(i+" ");
        } 
    }
}