using System;
using System.Collections.Generic;
using System.Text;

public class Program
{

    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] nums = new int[10];
        HashSet<int> hset1 = new HashSet<int>();

        for (int i = 0; i < 10; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            nums[i] %= 42;

        }

        for (int i = 0; i < 10; i++)
        {
            hset1.Add(nums[i]);

        }

        sb.Append(hset1.Count);
        Console.WriteLine(sb.ToString());


    }

}
