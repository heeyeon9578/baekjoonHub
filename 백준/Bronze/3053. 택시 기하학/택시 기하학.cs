using System;

class B_Diary
{
    static void Main()
    {
        int R = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.PI*R*R);  //유클리드 기하학에서 원의 넓이
        Console.WriteLine(2*R*R);  //택시 기하학에서 원의 넓이
    }
}