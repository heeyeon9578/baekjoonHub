using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {

        //입력
        int num = int.Parse(Console.ReadLine());

        //홀짝결정
        int count = 1;

        //인덱스
        int m = 0;

        //분자 배열 만들기
        int[] numArray = new int[num];

        //분자
        while (m < num)
        {
            if (count % 2 == 0) //count가 짝수 
            {
                for (int k = 1; k < count+1; k++)
                {
                    if (m < num)
                    {
                        numArray[m++] = k;
                    }
                    
                }
            }
            else //count가 홀수
            {
                for (int j = count; j > 0; j--)
                {
                    if(m < num)
                    {
                        numArray[m++] = j;
                    }
                    
                }
            }

            count++;
        }

        count = 0;
        m = 0;

        //분모배열
        int[] numArray1 = new int[num];
        //분모
        while (m < num)
        {
            if (count % 2 != 0) //count가 홀수
            {
                for (int k = 1; k < count + 1; k++)
                {
                    if (m < num)
                    {
                        numArray1[m++] = k;
                    }
                    
                }
            }
            else //count가 짝수
            {
                for (int j = count; j > 0; j--)
                {
                    if (m < num)
                    {
                        numArray1[m++] = j;
                    }
                    
                }
            }

            count++;
        }

        //정답
        Console.WriteLine($"{numArray[numArray.Length-1]}/{numArray1[numArray1.Length - 1]}");

       
    }
}
