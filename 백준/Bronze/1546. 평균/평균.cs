using System;
using System.Collections.Generic;
using System.Text;

public class Program
{

    public static void Main()
    {
/*        StringBuilder sb = new StringBuilder();*/
        //입력 받을 개수 입력받기
        int T = int.Parse(Console.ReadLine());
        //값 입력 받기
        String[] inputs = Console.ReadLine().Split(' ');

        //string을 float로 파싱할 배열
        float[] inputs_float = new float[T];


        //string 배열을 float로 파싱
        for (int i = 0; i < T; i++)
        {
            inputs_float[i] = float.Parse(inputs[i]);
        }

        //정렬을 통해 최고점 찾기
        Array.Sort(inputs_float);
        float largest_answer = inputs_float[(inputs_float.Length) - 1];
        float sum = 0;


        //성적 바꾸기 
        for (int i = 0; i < inputs.Length; i++)
        {
            inputs_float[i] = inputs_float[i] / largest_answer * 100;

            //합계
            sum += inputs_float[i];

        }
        //평균
        float avg = sum / T;

        //출력
        Console.WriteLine("{0:0.00####}", avg);




    }

}
