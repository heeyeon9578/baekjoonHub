using System;
public class Program
{

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i=1; i<n+1; i++)
        {
            sum += i;
        }

        Console.WriteLine(sum); 
        
    }

}
