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
        //테스트 케이스
        int T  = int.Parse(Console.ReadLine());
        String[] str = Console.ReadLine().Split(' ');

        int count = 0;
        int count1 = 0;
        for (int i = 0; i < T; i++)
        {
            for(int j=1; j < int.Parse(str[i])+1; j++)
            {
                if (int.Parse(str[i]) %j == 0)
                {
                    count++;
                }

                

            }
            if (count == 2)
            {
                count1++;

            }
            count = 0;
        }

        Console.WriteLine(count1);
        


    }
}
