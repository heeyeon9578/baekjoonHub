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
            int[] chs = { 1, 1, 2, 2, 2, 8 };
            string[] strArr = Console.ReadLine().Split(' ');
            int[] nums = new int[strArr.Length];
            for(int i=0; i<strArr.Length; i++)
            {
                nums[i] = int.Parse(strArr[i]);
            }

            for(int i=0; i<strArr.Length; i++)
            {
                chs[i] -= nums[i];
            }

            for (int i = 0; i < strArr.Length; i++)
            {
                Console.Write(chs[i] + " ");
            }
        }

    }
}

