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
            string[] str = reader.ReadLine().Split(' ');
            int[] intArray = new int[2];
            List<int> first = new List<int>();
            List<int> second = new List<int>();
            int leastAns = 0; //최소공배수
            int biggestAns = 0; //최대공약수
            for (int i = 0; i < 2; i++)
            {
                intArray[i] = int.Parse(str[i]);
            }
            int j = 1;
            while (j <= intArray[0])
            {
                if (intArray[0] % j == 0)
                {
                    first.Add(j);
                }
                j++;
            }
            j = 1;
            while (j <= intArray[1])
            {
                if (intArray[1] % j == 0)
                {
                    second.Add(j);
                }
                j++;
            }
            int whatIs = first.Count > second.Count ? second.Count : first.Count;
            for (int i = 0; i < whatIs; i++)
            {
                if(whatIs == second.Count)
                {
                    if (first.Contains(second[i]))
                    {
                        biggestAns = second[i];
                    }
                }
                else
                {
                    if (second.Contains(first[i]))
                    {
                        biggestAns = first[i];
                    }

                }
               
            }
            leastAns = (intArray[0] / biggestAns) * (intArray[1] / biggestAns) * biggestAns;
            writer.WriteLine(biggestAns);
            writer.WriteLine(leastAns);
            writer.Close();
            reader.Close();
        }
    }
}