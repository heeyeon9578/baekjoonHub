using System;
public class Program
{

    public static void Main()
    {
        String input = Console.ReadLine();
        String[] inputs = input.Split(' ');
        int ch1 = Convert.ToInt32(inputs[0]);
        int ch2 = Convert.ToInt32(inputs[1]);

        Console.WriteLine(ch1* ch2);


    }
}
