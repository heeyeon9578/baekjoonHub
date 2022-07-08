using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        //T입력받기
        int T = int.Parse(Console.ReadLine());
        

        for(int i =0; i<T; i++)
        {
            //h, w, n 입력받기
            String[] str = Console.ReadLine().Split(' ');
            int h = int.Parse(str[0]);
            int w = int.Parse(str[1]);
            int n = int.Parse((str[2]));
            string[] rooms = new string[h * w];
            int count = 0;

            for(int j=1; j<w+1; j++)
            {
                for(int k=1; k<h+1; k++)
                {
                    if (j < 10)
                    {
                        rooms[count++] = Convert.ToString(k) + "0"+ Convert.ToString(j);
                    }
                    else
                    {
                        rooms[count++] = Convert.ToString(k) + Convert.ToString(j);
                    }
                    
                }
            }

            Console.WriteLine(rooms[n-1]);


        }

    }
}
