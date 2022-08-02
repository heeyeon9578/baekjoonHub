using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Class1
    {
        static void Main(string[] args)
        {
            //[1]입력
            int num = int.Parse(Console.ReadLine());
            int[] numArray = new int[num];
            for(int i=0; i<num; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            //[2]처리
            Array.Sort(numArray);

            //[3]결과
            for (int i=0; i<numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
            
        }

        
    }
}
