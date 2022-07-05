using System;
public class Program
{

    public static void Main()
    {

        string[] s = Console.ReadLine().Split();

        Console.WriteLine(double.Parse(s[0]) / double.Parse(s[1]));


    }
}
