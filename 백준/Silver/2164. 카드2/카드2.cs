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

        public static int last = 0;
        public static Queue queue = new Queue();
        public static StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
        public static StreamReader reader = new StreamReader(Console.OpenStandardInput());
        public static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            
            //[1]입력
            int num = int.Parse(reader.ReadLine());
            last = 0;

            Queue queue = new Queue();

            for (int i = 0; i < num; i++)
            {
                queue.Enqueue(i+1);
                
            }


            while (queue.Count > 1)
            {

                //FIFO 라서 제일 먼저 들어간 데이터를 뽑음
                queue.Dequeue();
              /*  sb.AppendLine("- : " + queue.Peek().ToString() + "\n");*/

                last = (int)queue.Dequeue();
                queue.Enqueue(last);
               /* sb.AppendLine(" +: " + queue.Peek().ToString() + "\n");*/



            }



            sb.AppendLine(queue.Peek().ToString());
            writer.WriteLine(sb.ToString());
            writer.Close();
            reader.Close();

        }

    }

}