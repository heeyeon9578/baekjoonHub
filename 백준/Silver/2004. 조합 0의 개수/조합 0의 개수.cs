using System;
using System.Collections;
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
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            //[1]입력
            string[] str = reader.ReadLine().Split();
            long N = long.Parse(str[0]);
            long M = long.Parse(str[1]);


            long fiveCount= fivePower(N) - fivePower(N-M)-fivePower(M);
            long twoCount = twoPower(N) - twoPower(N - M) - twoPower(M);

            writer.WriteLine(Math.Min(fiveCount, twoCount));    

            writer.Close();
            reader.Close();

        }

        //5의 승수 구하기
        static long fivePower(long num)
        {
            long count = 0;
            while (num >= 5)
            {
                count += num / 5;
                num /= 5;
            }
            return count;
        }

        //2의 승수 구하기
        static long twoPower(long num)
        {
            long count = 0;
            while (num >= 2)
            {
                count += num / 2;
                num /= 2;
            }
            return count;
        }
    }

}