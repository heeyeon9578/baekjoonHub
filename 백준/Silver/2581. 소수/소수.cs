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
        //두 개의 값 사이에서 소수찾기
        int M  = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        int count = 0; //소수인지 판별하기 위해 2개 값만 저장하는지 검사하기
        int count1 = 0; //최소의 소수 구하기
        int sum = 0; //M에서 N사이에 소수를 모두 더하기


        for (int i = M; i < N+1; i++)
        {
            for(int j=1; j < i + 1; j++)
            {
                if (i %j == 0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                if(count1 == 0)
                {
                    count1 = i;
                }
                sum += i;

            }
            count = 0;
        }

        if(sum == 0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(sum);
            Console.WriteLine(count1);
        }

        


    }
}
