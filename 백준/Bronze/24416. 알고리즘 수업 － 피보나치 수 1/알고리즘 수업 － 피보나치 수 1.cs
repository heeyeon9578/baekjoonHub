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
        static int[] f;
        static int count;
        static int count1;
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            //[1]입력
            int num = int.Parse(reader.ReadLine());
            f = new int[num];

            fib(num);
            fib2(num);

            writer.WriteLine(count+1);
            writer.WriteLine(count1);

            writer.Close();
            reader.Close();
            
        }
        //재귀호출
        static int fib(int n)
        {
            
            if(n==1 || n == 2)
            {
                return 1;
            }
            else
            {
                count++;
                return fib(n-1)+ fib(n-2);
            }
        }
        //동적 프로그래밍
        static void fib2(int n)
        {
            
            f[0]=f[1]=1;
            for (int i = 2; i < n; i++)
            {
                count1++;
                f[i]= f[i - 1] + f[i - 2];
            }
            
        }

    }

}