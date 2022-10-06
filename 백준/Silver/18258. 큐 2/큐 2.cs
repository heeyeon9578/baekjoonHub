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
            int last = 0;
            Queue queue = new Queue();
            for (int i = 0; i < num; i++)
            {
                string[] str = reader.ReadLine().Split(' ');
                if (str.Length > 1)
                {
                    last = int.Parse(str[1]);

                }
                switch (str[0])
                {
                    case "push":
                        queue.Enqueue(last);
                        break;
                    case "pop":
                        sb.AppendLine(queue.Count != 0 ? queue.Dequeue().ToString() : "-1");
                        break;
                    case "empty":
                        sb.AppendLine(queue.Count == 0 ? "1" : "0");
                        break;
                    case "size":
                        sb.AppendLine(queue.Count.ToString());
                        break;
                    case "front":
                        sb.AppendLine(queue.Count != 0 ? queue.Peek().ToString() : "-1");
                        break;
                    case "back":
                        sb.AppendLine(queue.Count != 0 ? last.ToString() : "-1");
                        break;
                }

            }



            writer.WriteLine(sb.ToString());
            writer.Close();
            reader.Close();
            
        }
        

    }

}