using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {

        //테스트 케이스 입력받기
        int T = int.Parse(Console.ReadLine());

        for(int i = 0; i < T; i++)
        {
            //반복할 횟수 및 단어 입력받기 
            String[] word = Console.ReadLine().Split(' ');
            int repeat = int.Parse(word[0]);
            Char[] wordChar = word[1].ToCharArray();

            for(int j = 0; j < wordChar.Length; j++)
            {
                for(int k=0; k<repeat; k++)
                {
                    Console.Write($"{wordChar[j]}");
                }
                
            }
            Console.Write("\n");

        }
       


        

    }
}
