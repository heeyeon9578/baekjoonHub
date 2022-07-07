using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
       String str = Console.ReadLine();
       char[] chars = str.ToCharArray();
       int answer = 0;

       for(int i = 0; i < chars.Length; i++)
        {
            if(chars[i] == 'A' || chars[i] == 'B' || chars[i] == 'C')
            {
                answer += 2;
            }else if(chars[i] == 'D'|| chars[i] == 'E'|| chars[i] == 'F')
            {
                answer += 3;
            }
            else if (chars[i] == 'G' || chars[i] == 'H' || chars[i] == 'I')
            {
                answer += 4;
            }
            else if (chars[i] == 'J' || chars[i] == 'K' || chars[i] == 'L')
            {
                answer += 5;
            }
            else if (chars[i] == 'M' || chars[i] == 'N' || chars[i] == 'O')
            {
                answer += 6;
            }
            else if (chars[i] == 'P' || chars[i] == 'Q' || chars[i] == 'R'|| chars[i] == 'S')
            {
                answer += 7;
            }
            else if (chars[i] == 'T' || chars[i] == 'U' || chars[i] == 'V')
            {
                answer += 8;
            }
            else if (chars[i] == 'W' || chars[i] == 'X' || chars[i] == 'Y'|| chars[i] == 'Z')
            {
                answer += 9;
            }
            
        }

       Console.WriteLine(answer+chars.Length);   
    }
}
