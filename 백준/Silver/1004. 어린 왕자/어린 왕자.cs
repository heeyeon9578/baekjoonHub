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
            int T = int.Parse(Console.ReadLine());
            
            

            while (T > 0)
            {
                int[] startEnd = new int[4];
                string[] dots = Console.ReadLine().Split();

                for (int i = 0; i < 4; i++)
                {
                    startEnd[i] = int.Parse(dots[i]);    //시작과 끝 점     
                }

                int planum = int.Parse(Console.ReadLine());
                int[,] plaData = new int[planum, 3];
                for(int i=0; i<planum; i++)
                {
                    string[] pla = Console.ReadLine().Split();
                    for(int j=0; j<3; j++)
                    {
                        plaData[i, j] = int.Parse(pla[j]);
                    }
                }

                int goIn = 0;
                for(int i=0; i<planum; i++)
                {
                    double startpla = Math.Sqrt(Math.Pow(startEnd[0] - plaData[i, 0], 2) + Math.Pow(startEnd[1] - plaData[i, 1], 2));
                    double endpla = Math.Sqrt(Math.Pow(startEnd[2] - plaData[i, 0], 2) + Math.Pow(startEnd[3] - plaData[i, 1], 2));
                    int radius = plaData[i, 2];
                    if (startpla < radius)
                    {
                        if (radius < endpla)
                        {
                            goIn += 1;
                        }
                    }else if(radius > endpla)
                    {
                        goIn += 1;
                    }
                }

                Console.WriteLine(goIn);
                T--;
            }
        }
    }
}