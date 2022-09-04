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

            string str = "1 1";
            while (str != "0 0")
            {
                str = reader.ReadLine();
                if(str == "0 0") { break; }
                string[] str1 = str.Split();
                int[] intArray = new int[str.Length];
                intArray[0] = int.Parse(str1[0]);
                intArray[1] = int.Parse(str1[1]);

                if (intArray[1] % intArray[0] == 0)
                {
                    writer.WriteLine("factor");
                }
                else if (intArray[0] % intArray[1] == 0)
                {
                    writer.WriteLine("multiple");

                }
                else
                {
                    writer.WriteLine("neither");

                }

               
            }

            writer.WriteLine();
            writer.WriteLine();
            writer.Close();
            reader.Close();
        }
    }
}