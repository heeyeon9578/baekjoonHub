using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        int N1 = int.Parse(Console.ReadLine());
        int N2 = N1 / 5;
 
        int ans = -1;
        int ans2 = -1;
        for (int i = N2; i > -1; i--)
        {
            if (((N1 - (5 * i)) % 3) == 0)
            {
                ans = i;
                ans2 = (N1 - (5 * i)) / 3;
 
                break;
            }
        }

        if(ans == -1)
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine(ans+ ans2);
        }

    }
}
