using System;
using System.Text;

public class Program
{

    public static void Main()
    {
        StringBuilder sb = new StringBuilder(); 
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            sb.Append((i+1).ToString()+"\n");    
            
        }

        Console.WriteLine(sb.ToString());

    }

}
