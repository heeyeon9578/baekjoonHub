using System;
using System.Text;

public class Program
{

    public static void Main()
    {
        int answer_idx = 0;
        StringBuilder sb = new StringBuilder();
        int[] nums = new int[9];
        int[] nums_A = new int[9];
        for (int i = 0; i < 9; i++)
        {
            int N = int.Parse(Console.ReadLine());
            nums[i] = N;
            nums_A[i] = N;
        }
        Array.Sort(nums);

        int answer_large = nums[8];
        for(int i = 0; i < 9; i++)
        {
            if (nums_A[i] == answer_large)
            {
                answer_idx = i+1;
            }
        }
        sb.Append(answer_large+"\n");
        sb.Append(answer_idx);
        Console.WriteLine(sb.ToString());

    }

}
