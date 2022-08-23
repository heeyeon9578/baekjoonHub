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
            int[] xArray = new int[3];
            int[] yArray = new int[3];

            int[] count = new int[3];
            int[] count2 = new int[3];


            int ansX = 0;
            int ansY = 0;


          
            for(int i=0; i<3; i++)
            {
                string[] str = reader.ReadLine().Split();
                xArray[i] = int.Parse(str[0]);
                yArray[i] = int.Parse(str[1]);
            }

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if (xArray[i] == xArray[j])
                    {
                        count[i]++;
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (yArray[i] == yArray[j])
                    {
                        count2[i]++;
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (count[i] == 1)
                {
                    ansX = xArray[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (count2[i] == 1)
                {
                    ansY = yArray[i];
                }
            }



            writer.WriteLine(ansX + " " + ansY);


            writer.Close();
            reader.Close();
        }
    }
}