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
        word = word.ToUpper();  
/*      Char[] wordChar = word.ToCharArray();
        int[] wordInt = new int[wordChar.Length];*/

        //A~Z 까지 들어있는 배열 만들기
        Char[] A_Z = new Char[26];
        for(int i =0; i < 26; i++)
        {
            A_Z[i] = (char)((int)'A' + i);
        }

        //답안 배열 만들기
        Char[] answer = new Char[26];

        //중복세기
        for (int i = 0; i < word.Length; i++)
        {
            for(int j = 0; j < A_Z.Length; j++)
            {
                if (word[i] == A_Z[j])
                {
                    answer[j]++;
                }
            }
        }

        
        //최대값이 존재하는 인덱스를 저장할 변수
        int num = 0;
        //현재 최대값을 저장할 변수
        int high = 0;
        //최대값이 여러개인 경우 true가 됨
        bool same = false;


        for(int i=0; i<answer.Length; i++)
        {
            if(answer[i] == high && answer[i] != 0)
            {
                same = true;
            }

            if (answer[i] > high)
            {
                high = answer[i];
                num = i;
                same = false;
            }
        }

        //결과
        if (same)
        {
            Console.WriteLine('?');
        }
        else
        {
            Console.WriteLine(A_Z[num]);
        }

    }
}
