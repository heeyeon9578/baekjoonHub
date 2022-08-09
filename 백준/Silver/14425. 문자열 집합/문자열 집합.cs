using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//
//

namespace Project2
{
    class Class1
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            StreamWriter streamWriter = new StreamWriter(Console.OpenStandardOutput());
            StreamReader streamReader = new StreamReader(Console.OpenStandardInput());
            Dictionary<string, int> dic = new Dictionary<string, int>();

            string[] str = Console.ReadLine().Split();
            int num = int.Parse(str[0]);
            int ans = int.Parse(str[1]);
            int sum = 0;

            for(int i=0; i<num; i++)
            {
                string str1 = Console.ReadLine();
                dic.Add(str1, 0);

            }

            for(int j=0; j<ans; j++)
            {
                string str2 = Console.ReadLine();
                if (dic.ContainsKey(str2))
                {
                    dic[str2]++;
                }
            }

            foreach(int values in dic.Values)
            {
                sum += values;
            }

            streamWriter.WriteLine(sum);

            streamReader.Close();
            streamWriter.Close();

           
        }

    }
}

