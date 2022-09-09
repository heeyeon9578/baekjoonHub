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
            int N = int.Parse(reader.ReadLine());   
           for(int i=1; i < 10; i++)
            {
                sb.Append((N+" * "+i +" = "+ N*i).ToString()+ "\n");
            }

            writer.WriteLine(sb);
            
            
            writer.Close();
            reader.Close();
        }
    }
}