using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project2
{
    class Class1
    {
        static void Main(string[] args)
        {
            //입력 
            String[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            Console.WriteLine(combi(a,b));

            int combi(int n, int k)
            {
                if(k==0 || n == k)
                {
                    return 1;
                }
                else
                {
                    return combi(n - 1, k) + combi(n - 1, k - 1);

                }
            }
        }
    }
}