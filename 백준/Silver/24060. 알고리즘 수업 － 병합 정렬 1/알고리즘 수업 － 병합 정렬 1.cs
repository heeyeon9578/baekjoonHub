using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project2
{
    public static class Class1
    {
        public static int count = 0;
        public static int ans = 0;
        static void merge_sort(int[] intArr, int p, int r, int num1, int[] temp)
        {
            //q는 중간값
            if (p < r)
            {
                int q = (p + r) / 2;
                merge_sort(intArr, p, q, num1, temp);
                merge_sort(intArr, q + 1, r, num1, temp);
                merge(intArr, p, q, r, num1, temp);
            }
        }
        static void merge(int[] intArr, int p, int q, int r, int num1, int[] temp)
        {
            if (count == num1)
            {
                return;
            }
            int i = p;
            int j = q + 1;
            int t = 0;
            //A[p..q]와 A[q+1..r]을 병합하여 A[p..r]을 오름차순 정렬된 상태로 만든다.
            //A[p..q]와 A[q+1..r]은 이미 오름차순으로 정렬되어 있다.
            while (i <= q && j <= r)
            {
                if (intArr[i] <= intArr[j])
                {
                    temp[t++] = intArr[i++];
                }
                else
                {
                    temp[t++] = intArr[j++];
                }
            }
            //왼쪽 배열 부분이 남은 경우
            while (i <= q)
            {
                temp[t++] = intArr[i++];
            }
            //오른쪽 배열 부분이 남은 경우
            while (j <= r)
            {
                temp[t++] = intArr[j++];
            }
            i = p; t = 0;
            //결과를 A[p..r]에 저장
            while (i <= r)
            {
                count++;
                ans = temp[t];
                if (count == num1)
                {
                    return;
                }
                intArr[i++] = temp[t++];
            }
        }
        public static void Main(string[] args)
        {
            //[1]Input
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            //배열의 크기, 저장 횟수 받기
            string[] str = reader.ReadLine().Split();
            int arrLen = int.Parse(str[0]);
            int num = int.Parse(str[1]);
            string[] str1 = reader.ReadLine().Split();
            int[] ints = new int[arrLen];
            for (int i = 0; i < arrLen; i++)
            {
                ints[i] = Convert.ToInt32(str1[i]);
            }
            int[] temp = new int[ints.Length];
            merge_sort(ints, 0, ints.Length - 1, num, temp);
            if (count != num)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(ans);
            }
        }
    }
}