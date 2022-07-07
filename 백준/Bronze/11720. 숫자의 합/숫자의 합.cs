using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        String nums = Console.ReadLine();
        Char[] nums_toChar= nums.ToCharArray();
        int[] nums_toInt = new int[nums.Length];
        int sum = 0;
        for(int i = 0; i < N; i++)
        {
            nums_toInt[i] = int.Parse(nums_toChar[i].ToString());
            sum += nums_toInt[i];
        }

        Console.WriteLine(sum);



    }
}
