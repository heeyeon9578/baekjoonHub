using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        //단어 N개 입력받기
        int num = int.Parse(Console.ReadLine());
        string[] words = new string[num];
        int count=0;

        for(int i = 0; i < num; i++)
        {
            words[i] = Console.ReadLine();

            if (groupCheck(words[i]))
            {
                count++;
            }
        }

        Console.WriteLine(count);

        //그룹체커 함수
        bool groupCheck(string x)
        {
            for(int i =0; i<x.Length; i++)
            {
                for(int j=i; j<x.Length; j++)
                {
                    if(j-i > 1)
                    {
                        if (x[i] == x[j])
                        {
                            return false;
                        }
                    }

                    if (x[i] == x[j])
                    {
                        i += j - i;
                    }
                }
            }

            return true;
        }
    }
}
