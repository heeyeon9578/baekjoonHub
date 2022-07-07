using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {

        //단어 입력받기
        String word = Console.ReadLine();
        //단어를 분해하여 Char로 만들기
        Char[] word_char = word.ToCharArray();

        //a~z 배열 만들기
        int[] a_z = new int[26];

        //초기값 -1
        for(int i = 0; i < a_z.Length; i++)
        {
            a_z[i] = -1;
        }

        //값주기
        for(int i = 0; i < word_char.Length; i++)
        {
            if (a_z[word_char[i] - 97] == -1)
            {
                a_z[word_char[i] - 97] = i;
            }
           
        }

        //출력하기
        foreach(int i in a_z)
        {
            Console.Write($"{i} ");
        }

    }
}
