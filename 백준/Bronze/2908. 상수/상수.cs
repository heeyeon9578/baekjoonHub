using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        char temp = ' ';
        String[] nums = Console.ReadLine().Split(' ');
        string[] str = new string[2];
        for (int i = 0; i < nums.Length; i++)
        {
            Char[] chars = nums[i].ToCharArray();
            temp = chars[0];
            chars[0] = chars[2];
            chars[2] = temp;



            str[i] = string.Concat(chars);
        }

        int a = int.Parse(str[0]);
        int b = int.Parse(str[1]);

        Console.WriteLine(a > b ? a : b);
    }
}
