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

            int count = 0;
            int count2 = 0;
            for(int i=0; i<str.Length; i++)
            {
                intArray[i] = int.Parse(str[i]);
            
            }

            

            for(int i=0; i<str.Length; i++)
            {
                if (intArray[i] ==i+1)
                {
                    count++;
                }else if(intArray[i]== 8 - i)
                {
                    count2++;
                }
                else
                {
                    
                    break;
                }
            }

            if (count == 8)
            {
                writer.WriteLine("ascending");
            }else if (count2 == 8)
            {
                writer.WriteLine("descending");
            }
            else
            {
                writer.WriteLine("mixed");
            }

            writer.Close();
            reader.Close();

          

        }

    }
}