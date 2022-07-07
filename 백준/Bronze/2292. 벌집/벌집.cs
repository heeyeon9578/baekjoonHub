using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int x = 1; // 답 
        long range = 1;  //범위
        long temp = 1; //6의 배수를 더하기 위해서 사용

        while (true)
        {
            
            if (range >= num)
            {
                break;
            }
            temp = 6 * x++;
            range += temp;
           

        }
        Console.WriteLine(x);
    }
}
