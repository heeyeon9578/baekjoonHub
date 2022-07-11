using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

public class Program
{

    public static void Main()
    {
        String[] str = Console.ReadLine().Split(' ');
        BigInteger a = BigInteger.Parse(str[0]);
        BigInteger b = BigInteger.Parse(str[1]);

        Console.WriteLine(a + b);

    }
}
