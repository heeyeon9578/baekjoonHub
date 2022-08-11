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
            
            
            Dictionary<string, string> li =new Dictionary<string, string>();
            Dictionary<string, string> li2 = new Dictionary<string, string>();
            Dictionary<string, string> li3 = new Dictionary<string, string>();

            string[] nums1 = reader.ReadLine().Split();
            for (int i=0; i<N; i++)
            {
                li.Add(nums1[i],nums1[i]);
            }

            string[] nums2 = reader.ReadLine().Split();
            for (int j = 0; j < M; j++)
            {
                li2.Add(nums2[j], nums2[j]);
            }

            for (int j=0; j<M; j++)
            {
                if (li.ContainsKey(nums2[j]))
                {
                    li3.Add(nums2[j], nums2[j]);
                    li.Remove(nums2[j]);
                }
            }

       

            foreach(var i in li3.Keys)
            {
                li2.Remove(i);
            }


            writer.WriteLine(li.Count +li2.Count);
            writer.Close();
            reader.Close();

        }

    }
}