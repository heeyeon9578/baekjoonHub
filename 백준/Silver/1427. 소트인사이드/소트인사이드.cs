using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//[?] 선택 정렬 알고리즘
//무작위 데이터를 순서대로 [오름차순/내림차순] 정렬
//가장 [작은/큰] 데이터를 왼쪽

namespace Project2
{
    class Class1
    {
        static void Main(string[] args)
        {

            //[1]Input
            String str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            int[] intArray = new int[str.Length];


            //[2]process
            for(int i=0; i<str.Length; i++)
            {
                intArray[i] = (int)Char.GetNumericValue(charArray[i]);
            }
            Array.Sort(intArray);
            Array.Reverse(intArray);

            //[3]Output
            foreach(int i in intArray)
            {
                Console.Write(i);
            }
            
        }
        
    }
}

