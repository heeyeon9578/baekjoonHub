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
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();


            //[1]입력
            //테스트 케이스
            int T = int.Parse(reader.ReadLine());

            for (int j = 0; j < T; j++)
            {
                //아이템 수
                int item = int.Parse(reader.ReadLine());
                Dictionary<string, int> dic = new Dictionary<string, int>();

                for (int i = 0; i < item; i++)
                {
                    string[] a = reader.ReadLine().Split();

                    //옷 종류
                    string c = a[1];

                    if (dic.ContainsKey(c))
                    {
                        dic[c]++;
                    }
                    else
                    {
                        dic.Add(c, 1);  
                    }
                   
                }
                //[2]process
                int ans = 1;

                foreach(int val in dic.Values)
                {
                    ans *= (val+1);
                }

                writer.WriteLine(ans-1);


            }


            writer.Close();
            reader.Close();


        }

  


    }


}