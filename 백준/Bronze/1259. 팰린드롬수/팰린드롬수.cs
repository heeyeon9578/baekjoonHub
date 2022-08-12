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
            

            
            while (true)
            {
                int count = 0;
                string str = reader.ReadLine();
                if (str.Equals("0"))
                {
                    break;
                }
                
                char[] charArray = str.ToCharArray();
                char[] charArray2 = str.ToCharArray();

                Array.Reverse(charArray);
                for(int u=0; u<str.Length; u++)
                {
                    
                    if (charArray2[u].Equals(charArray[u]))
                    {
                        count++;
                    }
                    
                }


                if (count == str.Length)
                {
                    writer.WriteLine("yes");
                }
                else
                {
                   writer.WriteLine("no");
                } 
            }

            writer.Close();
            reader.Close();

        }

    }
}