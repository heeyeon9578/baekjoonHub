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
            List<int> ar = new List<int>();

            int input = int.Parse(reader.ReadLine());
            int[] arr = new int[input];
            for (int i = 0; i < input; i++)
            {
                arr[i] = int.Parse(reader.ReadLine());
            }

            Array.Sort(arr);


            int g = arr[1] - arr[0];

            for(int i=2; i<input; i++)
            {
                g = chlth(g, arr[i] - arr[i - 1]);

            }


            // gcd의 약수 모두 구하기
            for (int i=2; i*i<=g; i++)
            {
                if(i*i == g)
                {
                    ar.Add(i);
                }else if(g%i == 0)
                {
                    ar.Add(i);
                    ar.Add(g / i);
                }
            }

            ar.Add(g);
            ar.Sort();

            int[] newarr = ar.Distinct().ToArray();

            foreach(int a in newarr)
            {
                sb.Append(a+ " ");
            }

            writer.WriteLine(sb);
            writer.Close();
            reader.Close();
        }

        //최소공배수 구하는 함수, 유클리드 호제법
        static int chlth(int n, int m)
        {
            return (n % m == 0 ? m : chlth(m, n % m));
        }

        
    }

    
}