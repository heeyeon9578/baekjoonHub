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
            StringBuilder sb = new StringBuilder();
            string[] nums = reader.ReadLine().Split();
            int N = int.Parse(nums[0]);
            int M = int.Parse(nums[1]);

            Dictionary<string, int> dic = new Dictionary<string, int>();
            Dictionary<string, int> dic2 = new Dictionary<string, int>();
            
 /*           List<string> li = new List<string>();
            List<string> li2 = new List<string>();*/
            List<string> ans = new List<string>();
            int count = 0;

            /*string[] str2 = new string[M];*/
            for(int i=0; i<N; i++)
            {
                dic.Add(reader.ReadLine(), 0);
            }
            for (int i = 0; i < M; i++)
            {
                string stt = reader.ReadLine();
                if (dic.ContainsKey(stt))
                {
                    ans.Add(stt);

                }
               
            }
            

            ans.Sort();
            writer.WriteLine(ans.Count);
            for (int i=0; i<ans.Count; i++)
            {
                sb.Append(ans[i]+"\n");
            }
            writer.WriteLine(sb.ToString());

            writer.Close();
            reader.Close();

        }

    }
}