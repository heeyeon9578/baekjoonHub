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
            //[1]Input
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            

             //입력 
            String[] str = reader.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            //int[,] ints = new int[a, b];


            writer.WriteLine(binomial2(a,b));

            int binomial2(int n, int k)
            {
                int[,] dp = new int[1003, 1003];

                for (int i = 0; i <= n; i++)
                    for (int j = 0; j <= Math.Min(k, i); j++)
                        if (i == j || j == 0)
                            dp[i,j] = 1;
                        else
                            dp[i,j] = (dp[i - 1,j] + dp[i - 1,j - 1]) % 10007;


                return dp[n,k];
            }
      
            /*//동적프로그래밍을 이용하면 중복되는 부분을 커버
            int combi(int n, int k)
            {

                if (k > n)
                    return 0;

                if (k == 0 || n == k)
                {
                    return 1;
                }
                else
                {
                    return combi(n - 1, k) + combi(n - 1, k - 1);

                }
            }*/
            writer.Close();
            reader.Close();
        }
    }
}