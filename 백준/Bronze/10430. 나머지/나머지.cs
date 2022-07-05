using System;
public class Program
{

    public static void Main()
    {
        String[] inputs = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(inputs[0]);
        int B = Convert.ToInt32(inputs[1]);
        int C = Convert.ToInt32(inputs[2]);

        Console.WriteLine((A + B) % C);
        Console.WriteLine(((A % C) + (B % C)) % C);
        Console.WriteLine((A*B) % C);
        Console.WriteLine(((A % C) * (B % C)) % C);
    }
}
