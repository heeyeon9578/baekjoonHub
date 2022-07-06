using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        


        //정답
        int count= 0;
        

        //숫자받기
        int num1 = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num1; i++)
        {
            if (hansu(i.ToString())) count++;
        }

        Console.WriteLine(count);

        //함수
        bool hansu(string num)
        {
            if (int.Parse(num) < 100) return true;

            int[] digits = new int[num.Length];

            for(int i=0; i < num.Length; i++)
            {
                digits[i] = num[i];
            }

            if ((digits[0] - digits[1]) == (digits[1] - digits[2]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
