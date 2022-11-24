using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Class1
    {
        static StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
        static StreamReader reader = new StreamReader(Console.OpenStandardInput());
        static StringBuilder sb = new StringBuilder();
        static void Main()
        {
            int[] score =new int[5];
            for(int i= 0; i < 5; i++)
            {
                score[i] = int.Parse(reader.ReadLine());
            }
            solution(score);
            writer.WriteLine(sb.ToString());    
            writer.Close();
            reader.Close();

        }
        public static void solution(int[] score)
        {
            Array.Sort(score);
            int sum = 0;
            int avg;
            int middle;

            for(int i=0; i < score.Length; i++)
            {
                sum+= score[i];
            }

            avg = sum / score.Length;
            middle = score[(score.Length / 2)];        
            sb.Append(avg.ToString() + "\n");
            sb.Append(middle.ToString() + "\n");


            
        }


    }
}
