using System;
public class Program
{

    public static void Main()
    {
        
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());
        
        int B_1 = B - (B/10)*10;
        int B_100 = (B/100);
        int B_10 = (B - (B_100 * 100 + B_1))/10;

        int result_1 = A * B_1;
        int result_2 = A * B_10;
        int result_3 = A * B_100;

        Console.WriteLine(result_1);
        Console.WriteLine(result_2);
        Console.WriteLine(result_3);
        Console.WriteLine(A * B);


    }
}
