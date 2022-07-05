using System;
public class Program
{

    public static void Main()
    {
        String[] inputs = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(inputs[0]);
        int b = Convert.ToInt32(inputs[1]);

        Console.WriteLine(a+ b);
        Console.WriteLine(a- b);
        Console.WriteLine(a* b);
        Console.WriteLine(a / b);
        Console.WriteLine(a% b);

    }
}
