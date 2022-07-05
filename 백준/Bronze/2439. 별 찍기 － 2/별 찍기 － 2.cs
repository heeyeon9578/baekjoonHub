using System;
using System.Text;

public class Program
{

    public static void Main()
    {
        StringBuilder sb = new StringBuilder(); 
        int N = int.Parse(Console.ReadLine());
        for(int i = 1; i < N+1; i++)
        {    
            for(int m=N-1; m>i-1; m--)
            {
                sb.Append(" ");
            }
            for (int j=0; j < i; j++)
            {
                sb.Append("*");
            }
            Console.WriteLine(sb.ToString());
            sb.Clear();
            
        }
    }

}
