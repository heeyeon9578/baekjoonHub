using System;
using System.Text;

public class Program
{

    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int a= int.Parse(Console.ReadLine());
        int b= int.Parse(Console.ReadLine());
        int c= int.Parse(Console.ReadLine());

        int a_b_c = a * b * c;
        String abc = a_b_c.ToString();
        int[] abc2 = new int[abc.Length];   
        int[] answer = new int[10];

        for (int i = 0; i < abc.Length; i++)
        {
            abc2[i] = (int)Char.GetNumericValue(abc[i]);
        }
        for (int i = 0; i < 10; i++)
        {
            answer[i]=0;
        }

        for (int i = 0; i < abc.Length; i++)
        {
            answer[abc2[i]]++;
        }
        sb.Append(answer);
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine(answer[j].ToString());
        }





    }

}
