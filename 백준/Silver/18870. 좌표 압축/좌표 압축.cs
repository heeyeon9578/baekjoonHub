using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//[?] 주어진 데이터의 순위, 등수 알고리즘

namespace Project2
{
    class Class1
    {
        static void Main(string[] args)
        {

            //[1]Input
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            int N = int.Parse(reader.ReadLine());
            string[] str = reader.ReadLine().Split();
            List<long> li = new List<long>();
            SortedSet<long> ss = new SortedSet<long>();
            Dictionary<long, int> dict = new Dictionary<long, int>();
            
            for(int i=0; i<N; i++)
            {
                li.Add(int.Parse(str[i]));
            }

            for (int i = 0; i < N; i++)
            {
                ss.Add(int.Parse(str[i]));
            }

            int idx = 0;
            foreach (var val in ss)
            {
                dict.Add(val, idx);
                idx++;
            }

            for (int i = 0; i < li.Count; i++)
            {
                writer.Write(dict[li[i]] + " ");
            }
            writer.WriteLine();

            writer.Close();
            reader.Close();

        }

    }
}