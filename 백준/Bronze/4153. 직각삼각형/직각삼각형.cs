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

            
            while (true)
            {
                string sentence = reader.ReadLine();
                string[] str = sentence.Split(' ');
                int[] intArr = new int[str.Length];
                if (sentence== "0 0 0")
                {
                    break;
                }
                for(int i=0; i<str.Length; i++)
                {
                    intArr[i] = int.Parse(str[i]);
                }

                Array.Sort(intArr);
                if (Math.Pow( intArr[0],2) + Math.Pow(intArr[1], 2) == Math.Pow(intArr[2], 2))
                {
                    writer.WriteLine("right");
                }
                else
                {
                    writer.WriteLine("wrong");
                }
            }
            
            





            writer.Close();
            reader.Close();
        }
    }
}