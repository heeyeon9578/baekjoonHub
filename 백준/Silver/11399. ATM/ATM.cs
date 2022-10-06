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
        static int[] f;
        static int count;
        static int count1;
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            //[1]입력
            int num = int.Parse(reader.ReadLine());
            string[] str = reader.ReadLine().Split();
            int[] intArr = new int[num];
            for(int i=0; i < num; i++)
            {
                intArr[i] = int.Parse(str[i]); 
            }

            int sum = 0;
            
            Array.Sort(intArr); 
            
           //[2]process
            for(int i=0; i<num; i++)
            {
                sum += intArr[i] *( num-i);
            
           
            }
           

            writer.WriteLine(sum);

            writer.Close();
            reader.Close();
            
        }
       

    }

}