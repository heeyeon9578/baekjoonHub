using System;
 
class Program {
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(n));
    }
 
    static int Factorial(int num)
    {
        if (num == 1 || num == 0)
            return 1;
        else
            return num * Factorial(num-1);
    }
}