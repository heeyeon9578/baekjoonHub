using System;
public class Program
{

    public static void Main()
    {
        int T = int.Parse(Console.ReadLine());
       
        for(int i = 0; i <T; i++)
        {
            String[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);

            Console.WriteLine(a+b);
        }
        
    }

}
