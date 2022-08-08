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

            int T = int.Parse(Console.ReadLine());
            List<(int, string)> list = new List<(int, string)>();

            for(int i=0; i<T; i++)
            {
                string[] str = Console.ReadLine().Split();
                list.Add((int.Parse(str[0]), str[1]));
            }

            var sortlist =list.OrderBy(x => x.Item1).ToList();

            for (int i = 0; i < T; i++)
            {
                Console.WriteLine($"{sortlist[i].Item1} {sortlist[i].Item2}");
            }

        }
        
    }
}

