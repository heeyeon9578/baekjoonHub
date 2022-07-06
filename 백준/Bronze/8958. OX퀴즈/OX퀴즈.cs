using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Program
{

    public static void Main()
    {
/*        StringBuilder sb = new StringBuilder();*/
        //입력 받을 개수 입력받기
        int T = int.Parse(Console.ReadLine());
        //값 입력 받기
        String[] inputs = new string[T];
        for (int i = 0; i < T; i++)
        {
            inputs[i] = Console.ReadLine();
        }

        //각 문장별로 split 하기
         for(int i = 0; i < T; i++)
        {
            char[] temp = inputs[i].ToCharArray();
            int j = 0;
            int resultScore = 0;
            int score = 0;

            while (true)
            {
                if (temp[j].ToString()== "O")
                {
                    score++;
                    resultScore +=score;
                }
                else
                {
                    score = 0;
                }

                j++;
                if (j == temp.Length) break;
            }

            Console.WriteLine(resultScore);
        }

    }

}
