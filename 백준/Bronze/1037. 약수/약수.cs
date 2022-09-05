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

            int N = int.Parse(reader.ReadLine());
            string[] str = reader.ReadLine().Split();
            int[] intArray = new int[str.Length];   
            for (int i = 0; i < N; i++)
            {
                intArray[i] = int.Parse(str[i]);
 
            }

            Array.Sort(intArray);
            int ans = intArray[0] * intArray[intArray.Length - 1];
            writer.WriteLine(ans);
            writer.Close();
            reader.Close();
        }
    }
}