using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            
            string[] widthAndHeight = Console.ReadLine().Split();
            int height = int.Parse(widthAndHeight[0]);
            int width = int.Parse(widthAndHeight[1]);   

            List<int> list1 = new List<int>(); //행렬1
            List<int> list2 = new List<int>(); //행렬2
            List<int> totalList = new List<int>();

            for(int i=0; i< height; i++) 
            {
                string[] line = Console.ReadLine().Split();
                for (int j=0; j < width; j++)
                {
                    list1.Add(int.Parse(line[j]));
                }
   
            }
            for (int i = 0; i < height; i++)
            {
                string[] line = Console.ReadLine().Split();
                for (int j = 0; j < width; j++)
                {
                    list2.Add(int.Parse(line[j]));
                }

            }

            for (int i = 0; i < width * height; i++)
            {
                totalList.Add(list1[i] + list2[i]);
            }

            int count = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(totalList[count++] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
