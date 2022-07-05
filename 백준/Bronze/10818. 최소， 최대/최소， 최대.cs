using System;
using System.Text;

public class Program
{

    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        String[] inputs = Console.ReadLine().Split(' ');
        int[] new_inputs = new int[N];
        for(int i = 0; i < inputs.Length; i++)
        {
            new_inputs[i] = int.Parse(inputs[i]);
        }
        Array.Sort(new_inputs);
        int answer_small = new_inputs[0];
        int answer_large = new_inputs[N - 1];

        sb.Append(answer_small+" "+answer_large);
        Console.WriteLine(sb.ToString());

    }

}
