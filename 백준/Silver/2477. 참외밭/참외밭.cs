using System;
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
            int K = Int32.Parse(Console.ReadLine());
            int[,] distance = new int[6, 2];
            string[] tempStr;
            int width = 0;
            int height = 0;
            int blankwidth = 0;
            int blankheight = 0;
            int total = 0;
            for (int i = 0; i < 6; i++)
            {
                tempStr = Console.ReadLine().Split();
    
                distance[i, 0] = Int32.Parse(tempStr[0]);
                distance[i, 1] = Int32.Parse(tempStr[1]);
                if (distance[i, 0] == 1 || distance[i, 0] == 2)
                    width += distance[i, 1];
                if (distance[i, 0] == 3 || distance[i, 0] == 4)
                    height += distance[i, 1];
            }
            for (int i = 0; i < 6; i++)
            {
                if (distance[i, 0] == distance[i + 2 > 5 ? (i + 2) - 6 : i + 2, 0] && distance[i + 1 > 5 ? (i + 1) - 6 : i + 1, 0] == distance[i + 3 > 5 ? (i + 3) - 6 : i + 3, 0])
                {
                    blankheight = distance[i + 1 > 5 ? (i + 1) - 6 : i + 1, 1];
                    blankwidth = distance[i + 2 > 5 ? (i + 2) - 6 : i + 2, 1];
                }
            }
            width /= 2;
            height /= 2;
            total = (width * height) - (blankheight * blankwidth);
            System.Console.WriteLine(total * K);
        }
    }
}