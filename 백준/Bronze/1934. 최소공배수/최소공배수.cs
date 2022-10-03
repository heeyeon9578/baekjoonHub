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
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(reader.ReadLine());
            for(int i=0; i<n; i++)
            {
                string[] input = reader.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                writer.WriteLine((a * b) / chlth(a, b));

            }

            writer.Close();
            reader.Close();
        }

        static int chlth(int n, int m)
        {
            return (n % m == 0 ? m : chlth(m, n % m));
        }

        
    }

    
}