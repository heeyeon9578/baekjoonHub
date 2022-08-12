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
            string[] str = reader.ReadLine().Split();

            int[] intArray = new int[str.Length];
            int sum = 0;
            for(int i=0; i<str.Length; i++)
            {
                intArray[i] = int.Parse(str[i]);
            }
            for (int i = 0; i < str.Length; i++)
            {
                sum += intArray[i] * intArray[i];
            }
            int na = 0;
            na = sum % 10;
            writer.WriteLine(na);

            writer.Close();
            reader.Close();

          

        }

    }
}