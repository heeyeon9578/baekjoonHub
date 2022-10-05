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


            //[1]입력
            
            int num = int.Parse(reader.ReadLine());
            int count = 0;

            while (num >= 5)
            {
                count += num / 5;
                num /= 5;
            }
            writer.WriteLine(count);
            writer.Close();
            reader.Close();


        }

  


    }


}