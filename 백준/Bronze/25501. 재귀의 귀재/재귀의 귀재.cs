using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project2
{
    public static class Class1
    {

        static public int count = 0;
        public static void Main(string[] args)
        {
            //[1]Input
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            //개수입력
            int N = int.Parse(reader.ReadLine());
           
           
            //[2] process
            for (int i=0; i<N; i++)
            {
                count = 0;
                string str = reader.ReadLine();
                char[] chaArray = str.ToCharArray();
                isPal(chaArray);
               /* writer.WriteLine(Class1.isPal(chaArray));*/
                
            }
            
            //[3] output
            
            writer.Close();
            reader.Close();
            

        }

        static public int recursion(char[] chaArr, int l, int r)
        {
            count++;
            if (l >= r) return 1;
            else if (chaArr[l] != chaArr[r]) return 0;
            else return recursion(chaArr, l + 1, r - 1);
            


        }

        static public void isPal(char[] chaArr2)
        {
           Console.WriteLine(recursion(chaArr2, 0, chaArr2.Length - 1) + " " + count);
        }

      


    }
}