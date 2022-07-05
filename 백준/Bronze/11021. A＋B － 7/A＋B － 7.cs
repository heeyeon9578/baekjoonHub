using System;
using System.Text;

public class Program
{

    public static void Main()
    {
        StringBuilder sb = new StringBuilder(); 
        int N = int.Parse(Console.ReadLine());
        int[] a = new int[N];
        int[] b = new int[N];

        for(int i = 0; i < N; i++)
        {
            String[] inputs = Console.ReadLine().Split(' ');
            a[i] = int.Parse(inputs[0]);
            b[i] = int.Parse(inputs[1]);

            sb.Append("Case #"+(i+1)+": "+(a[i] + b[i])+"\n");
               
            
        }

        Console.WriteLine(sb.ToString());

    }

}
