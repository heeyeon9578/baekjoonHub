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

            int num = int.Parse(reader.ReadLine());
            string[] numArray = reader.ReadLine().Split();
            int[] intNum = new int[num];
            int num2 = int.Parse(reader.ReadLine());
            string[] numArray2 = reader.ReadLine().Split();
            int[] intNum2 = new int[num2];
            int[] bs = new int[num2];
            for (int i=0; i<num; i++)
            {
                intNum[i] = int.Parse(numArray[i]);
            }
            for(int j=0; j<num2; j++)
            {
                intNum2[j] = int.Parse(numArray2[j]);
            }
            Array.Sort(intNum);
            /*foreach(var i in intNum)
            {
                writer.WriteLine(i);
            }*/
            for (int j = 0; j < num2; j++)
            {
               bs[j]  = Array.BinarySearch(intNum, intNum2[j]);
                if (bs[j] < 0)
                {
                    bs[j] = 0;
                }
                else
                {
                    bs[j] = 1;
                }
                sb.Append(bs[j] + "\n");
            }
            writer.WriteLine(sb);



            writer.Close();
            reader.Close();
        }
    }
}