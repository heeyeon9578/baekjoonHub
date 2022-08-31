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
            //[1]Input
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int T = int.Parse(reader.ReadLine());
            
            while (T > 0)
            {
                int count = 0;
                string[] str = reader.ReadLine().Split(' ');
                int x1 = int.Parse(str[0]);
                int y1 = int.Parse(str[1]);
                int d1 = int.Parse(str[2]);
                int x2 = int.Parse(str[3]);
                int y2 = int.Parse(str[4]); 
                int d2 = int.Parse(str[5]); 


                double distance = Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2));
                int sum = d1 + d2;
                int sub = Math.Abs(d1 - d2);
                if(distance != 0)
                {
                    if (sum == distance)
                    {
                        count += 1;
                    }
                    else if (sub == distance)
                    {
                        count += 1;

                    }
                    else if (sum < distance)
                    {
                        count += 0;
                    }
                    else if (distance < sub)
                    {
                        count += 0;
                    }
                    else
                    {
                        count += 2;
                    }

                }
                else
                {
                    if (d1 == d2)
                    {
                        writer.WriteLine(-1);
                        T--;
                        continue;
                    }
                    else
                    {
                        count += 0;
                    }
                }

                writer.WriteLine(count);
                T--;
            }
          
            



            writer.WriteLine();
            writer.WriteLine();
            writer.Close();
            reader.Close();
        }
    }
}