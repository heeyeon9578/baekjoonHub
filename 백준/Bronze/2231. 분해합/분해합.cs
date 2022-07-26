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
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(solution(N));



            int hapFunc(int num)
            {
                int hap = num;
                while(num != 0)
                {
                    int rest = num % 10;
                    hap += rest;
                    num /= 10;
                }

                return hap;
            }

            int solution(int N1)
            {
                for(int i=0; i<=1000000; i++)
                {
                    if (hapFunc(i) == N1)
                    {
                        return i;
                    }
                }

                return 0;
            }



        }

        
    }
}
