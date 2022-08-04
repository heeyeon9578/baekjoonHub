using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project1
{
    class Class1
    {
        static void Main(string[] args)
        {
            //[1]입력
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int N = int.Parse(sr.ReadLine());
            int[] cnt = new int[10001];
            //[2]처리
            for (int i=0; i<N; i++)
            {
                int num = int.Parse(sr.ReadLine());
                cnt[num]++;
            }
            //[3]결과
            for (int i=0; i<cnt.Length; i++)
            {
                for(int j=0; j<cnt[i]; j++)
                {
                    sw.WriteLine(i);
                }
            }

            sr.Close();
            sw.Close();

        }

        
    }
}
