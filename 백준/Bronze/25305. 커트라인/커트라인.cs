using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//
//

namespace Project2
{
    class Class1
    {
        static void Main(string[] args)
        {

            string[] strArr = Console.ReadLine().Split(' ');
            int[] intArr = new int[strArr.Length];
            intArr[0] = int.Parse(strArr[0]);
            intArr[1] = int.Parse(strArr[1]);
            int[] intArr2 = new int[intArr[0]];
            string[] strArr2 = Console.ReadLine().Split(' ');

            for (int i=0; i<intArr[0]; i++)
            {
                intArr2[i] = int.Parse(strArr2[i]);
            }
            Array.Sort(intArr2);
            Array.Reverse(intArr2);
            Console.WriteLine(intArr2[intArr[1]-1]);
        }

    }
}

