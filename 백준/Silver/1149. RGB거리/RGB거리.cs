using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Class1
    {
        static int[] memoization = new int[10000];
        static void Main(string[] args)
        {
            //[1]data
            int num = int.Parse(Console.ReadLine());
            int[,] twowayArray= new int[num+1,3];
            for(int i=1; i<num+1; i++)
            {
                int R = 0;
                int G = 0;
                int B = 0;
                string[] tempNum = Console.ReadLine().Split();

                R= int.Parse(tempNum[0]);
                G= int.Parse(tempNum[1]);
                B= int.Parse(tempNum[2]);

                twowayArray[i, 0] = Math.Min(twowayArray[i - 1,1], twowayArray[i - 1, 2]) + R;
                twowayArray[i, 1] = Math.Min(twowayArray[i - 1,0], twowayArray[i - 1, 2]) + G;
                twowayArray[i, 2] = Math.Min(twowayArray[i - 1,0], twowayArray[i - 1, 1]) + B;
            }


            //[2]Process
            Console.WriteLine(Math.Min(twowayArray[num , 0],Math.Min( twowayArray[num , 1], twowayArray[num , 2])));
            

        }
    }
}
