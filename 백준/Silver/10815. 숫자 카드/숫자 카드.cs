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
            StringBuilder stringBuilder = new StringBuilder();
            StreamReader streamReader = new StreamReader(Console.OpenStandardInput());
            StreamWriter streamWriter = new StreamWriter(Console.OpenStandardOutput());
            int N = int.Parse(streamReader.ReadLine());
            string[] str = streamReader.ReadLine().Split();
            int[] intArr = new int[N];

            int T = int.Parse(streamReader.ReadLine());
            string[] str1 = streamReader.ReadLine().Split();
            int[] intArr1 = new int[T];

            int[] ans = new int[T];


            for (int i=0; i<N; i++)
            {
                intArr[i] = int.Parse(str[i]);

            }

            for (int i = 0; i < T; i++)
            {
                intArr1[i] = int.Parse(str1[i]);

            }

            //이진탐색을 위해 정렬
            Array.Sort(intArr);


            for (int i = 0; i < T; i++)
            {
                
                stringBuilder.Append(binarysearch(intArr, intArr1[i]) + " ");
            }

            streamWriter.WriteLine(stringBuilder);

            streamWriter.Close();
            streamReader.Close();

            int binarysearch(int[] lo, int a)
            {
                int mid=0;
                int first = 0;
                int last = lo.Length - 1;

                while (first <= last)
                {

                    mid = (first + last) / 2;

                    if (lo[mid] == a)
                    {
                        return 1;
                    }
                    else if (lo[mid] < a)
                    {
                        first = mid + 1;
                        
                    }
                    else
                    {
                        last = mid - 1;

                    }
                }

               
                return 0;
            }
        }
    }
}

