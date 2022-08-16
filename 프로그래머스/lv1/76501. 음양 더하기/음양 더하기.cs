using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int sum = 0;
        int[] ans = new int[absolutes.Length];
        for(int i=0; i<absolutes.Length; i++)
        {
            if (signs[i] == true)
            {
                ans[i] = absolutes[i];
            }
            else
            {
                ans[i] = absolutes[i] * (-1);
            }
            
        }
        for(int i=0; i<absolutes.Length; i++)
        {
            sum += ans[i];
        }

        return sum;
        
    }
}