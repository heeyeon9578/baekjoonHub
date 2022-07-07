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
        int count = 0;
        for(int i=0; i<chars.Length; i++)
        {


            if(chars[i] == 'c' && i< chars.Length-1)
            {
                if (chars[i+1] == '=' || chars[i+1]=='-')
                {
                    i += 1;
                }
            }


            if (chars[i]=='d' && i < chars.Length - 1)
            {
                if (chars[i + 1] == '-')
                {
                    i += 1; 
                }else if (chars[i + 1] == 'z'&&i < chars.Length - 2)
                {
                    if (chars[i+2] == '=')
                    {
                        i += 1;
                    }
                }
            }

            if (chars[i] == 'l' && i < chars.Length - 1)
            {
                if (chars[i + 1] == 'j')
                {
                    i += 1;
                }
            }

            if (chars[i] == 'n' && i < chars.Length - 1)
            {
                if (chars[i + 1] == 'j' )
                {
                    i += 1;
                }
            }

            if (chars[i] == 's' && i < chars.Length - 1)
            {
                if (chars[i + 1] == '=' )
                {
                    i += 1;
                }
            }

            if (chars[i] == 'z' && i < chars.Length - 1)
            {
                if (chars[i + 1] == '=')
                {
                    i += 1;
                }
            }



            count++;


        }

        Console.WriteLine(count);
    }
}
