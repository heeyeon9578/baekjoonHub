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
            string str = reader.ReadLine();
           

            //정답이 될 중복제거된 값이 저장될 세트
            HashSet<string> chrList = new HashSet<string>();

            for(int n=0; n<str.Length; n++)
            {
                makeSubstring(str, n);
            }

            writer.WriteLine(chrList.Count);

            writer.Close();
            reader.Close();

            void makeSubstring(string st, int i)
            {
                
               for(int j=0;j<st.Length-i; j++)
                {
                    chrList.Add(str.Substring(j,i+1));
                   
                }
            }

        }

    }
}