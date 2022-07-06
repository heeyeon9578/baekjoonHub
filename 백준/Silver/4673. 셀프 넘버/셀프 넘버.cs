using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        HashSet<int> self_nums = new HashSet<int>();
        for(int i = 1; i < 10001; i++)
        {
            self_nums.Add(method_nums(i)); 
        }

        for(int j=1; j < 10001; j++)
        {
            if(self_nums.Contains(j))
            {
                continue;
            }
            Console.WriteLine(j);
        }
        
        int method_nums(int x) {

            if (x < 100)
            {
                x = x + (x / 10) + (x % 10);
            }else if (x < 1000)
            {
                x = x + (x / 100) + ((x % 100)-((x % 10)))/10 + (x%10);
            }else if (x < 10000)
            {
                x = x + x / 1000 + (x % 10) + (x % 1000 - x % 100) / 100 + (x % 100 - x % 10) / 10;
            }
         
            return x;
        }

    }
}
