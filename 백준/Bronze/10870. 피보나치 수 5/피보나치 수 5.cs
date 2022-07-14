using System;
 
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(fibo(n));
    }
    
    static int fibo(int n)
    {
        if(n <= 1)
        {
            return n;
        }
        else
        {
            return fibo(n-1) + fibo(n-2);
        }
    }
}
