using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1181.cs
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string s = Console.ReadLine();
                list.Add(s);
            }
            list = list.Distinct().ToList();
            list.Sort();
            list = list.OrderBy(x => x.Length).ToList();
            
            for(int i = 0; i < list.Count; i++)
            {
                string output = list[i];
                Console.WriteLine(output);
            }
        }
    }
}