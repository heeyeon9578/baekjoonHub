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
            List<int> li = new List<int>();
            string[] str = reader.ReadLine().Split();
            int[] strToInt = new int[str.Length];

            for(int i=0; i<strToInt.Length; i++)
            {
                strToInt[i] = int.Parse(str[i]);
            }

            li.Add(strToInt[0] - 0);
            li.Add(strToInt[1] - 0);
            li.Add(Math.Abs(strToInt[2] - strToInt[0]));
            li.Add(Math.Abs(strToInt[3] - strToInt[1]));

            li.Sort();
            writer.WriteLine(li[0]);

            writer.Close();
            reader.Close();
        }
    }
}