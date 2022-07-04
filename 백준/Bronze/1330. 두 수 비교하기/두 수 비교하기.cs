using System;
public class Program
{

    public static void Main()
    {
        //입력 첫째줄에 정수 A,B를 입력받는다.
        //정수 A,B는 공백(스페이스)로 구분되어진다.
        string[] a = Console.ReadLine().Split(' ');
        int numA = int.Parse(a[0]);
        int numB = int.Parse(a[1]);

        //출력 첫째줄에 값을 비교하여 '>', '<', '==' 비교연산자를 출력한다.
        if (numA > numB) Console.WriteLine(">");
        else if (numA < numB) Console.WriteLine("<");
        else if (numA == numB) Console.WriteLine("==");
    }
}