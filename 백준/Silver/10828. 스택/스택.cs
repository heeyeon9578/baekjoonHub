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
            while (num-- > 0)
            {
                string str = reader.ReadLine();
                List<string> li = str.Split().ToList(); 
                string str1 = li[0];
                int str2=0 ;
                if (li.Count ==2)
                {
                    str2 = int.Parse(li[1]);
                }
               

            


                switch (str1)
                {

                    case "push":
                        push(str2);
                        break;

                    case "pop":
                        sb.Append(pop()).Append('\n');
                        break;

                    case "size":
                        sb.Append(size()).Append('\n');
                        break;

                    case "empty":
                        sb.Append(empty()).Append('\n');
                        break;

                    case "top":
                        sb.Append(top()).Append('\n');
                        break;
                }
            }
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

        public static int size()
        {
            return indexSize;
        }

        public static int empty()
        {
            if (indexSize == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int top()
        {
            if (indexSize == 0)
            {
                return -1;
            }
            else
            {
                return stack[indexSize - 1];
            }
        }

    }

}