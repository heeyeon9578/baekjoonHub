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
        public static int[] stack;
        public static int indexSize = 0;
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            //[1]입력
            int num = int.Parse(reader.ReadLine());
            stack = new int[num];
            int sum = 0;

            while (num-- > 0)
            {
               
                int input = int.Parse(reader.ReadLine());
                if (input == 0)
                {
                    pop();
                }
                else
                {
                    push(input);
                }


            }

            for(int i=0; i<stack.Length; i++)
            {
                sum += stack[i];
            }
            sb.Append(sum.ToString());
            writer.WriteLine(sb.ToString());
            writer.Close();
            reader.Close();

        }
        public static void push(int item)
        {
            stack[indexSize] = item;
            indexSize++;
        }

        public static int pop()
        {
            if (indexSize == 0)
            {
                return -1;
            }
            else
            {
                int res = stack[indexSize - 1];
                stack[indexSize - 1] = 0;
                indexSize--;
                return res;
            }
        }

    }

}