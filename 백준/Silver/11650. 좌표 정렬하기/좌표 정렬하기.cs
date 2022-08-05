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

            //[1]Input
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            int n = int.Parse(reader.ReadLine());
            List<(int, int)> list = new List<(int, int)>();
            //[2]process
            for (int i=0; i<n; i++)
            {
                string[] str = reader.ReadLine().Split();
                int x = int.Parse(str[0]);
                int y = int.Parse(str[1]);
                list.Add((x, y));
            }

            var sortList = list.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList();
            //[3]Output
            for (int i=0; i<n; i++)
            {
                writer.WriteLine($"{sortList[i].Item1} {sortList[i].Item2}");
            }

            writer.Close();
            reader.Close();


        }
        
    }
}

