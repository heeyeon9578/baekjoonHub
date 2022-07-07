using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        //A, B, V 입력받기
        String[] str = Console.ReadLine().Split(' ');
        int A = int.Parse(str[0]);
        int B = int.Parse(str[1]);
        int V = int.Parse((str[2]));

        int count = (V - B) / (A - B);
        if ((V - B) % (A - B) != 0)
        {
            count++;
        }

        Console.WriteLine(count); 

    }
}
