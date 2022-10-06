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
        static StringBuilder sb = new StringBuilder();

        static int[] arr;
        static bool[] visit;
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            //[1]입력
            string[] str = reader.ReadLine().Split();
            int num = int.Parse(str[0]);
            int count = int.Parse(str[1]);

            arr = new int[count];
            visit = new bool[num];
            dfs(num, count, 0);
            writer.WriteLine(sb.ToString());
            writer.Close();
            reader.Close();

        }

        static void dfs(int a, int b, int dep)
        {
            if (dep == b)
            {
                foreach (int val in arr)
                {
                    sb.Append(val + " ");
                }
                sb.AppendLine();
                return;
            }

            for (int i = 0; i < a; i++)
            {
                if (!visit[i])
                {
                    visit[i] = true;
                    for (int j=0; j<i; j++)
                    {
                        visit[j] = true;
                    }
                    
                    arr[dep] = i + 1;
                    dfs(a, b, dep + 1);
                    visit[i] = false;
                    for (int j = 0; j < i; j++)
                    {
                        visit[j] = false;
                    }
                }
            }
        }

    }

}