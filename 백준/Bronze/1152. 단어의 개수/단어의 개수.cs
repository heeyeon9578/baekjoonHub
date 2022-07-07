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
        String word = Console.ReadLine().Trim();
        String[] word_1 = word.Split(' ');
        int count = 0;
        for (int i = 0; i < word_1.Length; i++)
        {
            if (String.IsNullOrEmpty(word_1[i]))
            {
                count++;
            }
        }

        // 단어와 공백으로 이루어진 배열 - 공백의 수 = 단어 수
        Console.WriteLine($"{word_1.Length - count}");

    }
}
