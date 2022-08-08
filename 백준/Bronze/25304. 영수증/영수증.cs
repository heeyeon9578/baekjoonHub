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
            int sum = int.Parse(Console.ReadLine());
            int num= int.Parse(Console.ReadLine());
            int realsum = 0;

            for(int i=0; i<num; i++)
            {
                string[] str = Console.ReadLine().Split();
                int price = int.Parse(str[0]);
                int nums = int.Parse(str[1]);
                realsum += (price * nums);
            }

            if (sum == realsum)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }



    }
}

