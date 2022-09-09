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
            int T = int.Parse(reader.ReadLine());   
           
            //int[,] ints = new int[a, b];
            for(int i = 0; i < T; i++)
            {

                String[] str = reader.ReadLine().Split();
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);
                int temp = 0;

                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                    
                }
                writer.WriteLine(binomial2(a, b));
            }

           

            int binomial2(int n, int k)
            {
                int[,] dp = new int[30, 30];

                for (int i = 0; i <= n; i++)
                    for (int j = 0; j <= Math.Min(k, i); j++)
                        if (i == j || j == 0)
                            dp[i, j] = 1;
                        else
                            dp[i, j] = dp[i - 1, j] + dp[i - 1, j - 1];


                return dp[n,k];
            }
      
            
            writer.Close();
            reader.Close();
        }
    }
}