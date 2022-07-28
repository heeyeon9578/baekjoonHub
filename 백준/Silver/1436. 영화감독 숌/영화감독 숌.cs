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
            int cnt = 0;
            int res = 666;

            //[2]처리
            while (true)
            {
                if (Convert.ToString(res).Contains("666"))
                    cnt++;

                if (num == cnt)
                    break;

                res++;
            }

            //[3]결과
            Console.WriteLine($"{res}");

        }

        
    }
}
