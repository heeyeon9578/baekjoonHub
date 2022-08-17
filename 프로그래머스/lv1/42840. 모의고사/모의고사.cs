using System;
using System.Linq;
using System.Collections.Generic;
public class Solution
{
    public int[] solution(int[] answers)
    {
        int[] first = new int[10000];
        int[] second = new int[10000];
        int[] third = new int[10000];

        int[] ans = new int[3];

        int[] firstAns = new int[] { 1, 2, 3, 4, 5 };
        int[] secondAns = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] thirdAns = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        List<int> li = new List<int>();

        /*   int a = 0; int b = 0; int u = 0;*/
        int q = 0;
        while (q < 10000)
        {
            for (int j = 0; j < 5; j++)
            {
                first[q++] = firstAns[j];

            }
        }
        q = 0;
        while (q < 10000)
        {
            for (int n = 0; n < 8; n++)
            {
                second[q++] = secondAns[n];
            }
        }
        q = 0;
        while (q< 10000)
        {
            for (int m = 0; m< 10; m++)
            {
                third[q++] = thirdAns[m];
            }
        }

    



        for (int i=0; i<answers.Length; i++)
        {
            if (answers[i] == first[i])
            {
                ans[0] += 1;
            }
            if(answers[i]== second[i])
            {
                ans[1] += 1;
            }
            if (answers[i] == third[i])
            {
                ans[2] += 1;
            }
        }


        int max = 0;
        for(int i=0; i<3; i++)
        {
            if (max < ans[i])
            {
                max = ans[i];
               
            }

        }
       
        for (int i = 0; i < 3; i++)
        {
            if (max ==ans[i])
            {
                li.Add(i + 1);

            }

        }
        li.Sort();
        
        return li.ToArray();

    }
}