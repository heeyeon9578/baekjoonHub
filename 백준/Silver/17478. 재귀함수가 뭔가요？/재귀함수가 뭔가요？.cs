public static class PS
{
    private static readonly StreamWriter sw;
    private static readonly string[] dialogues;

    private static readonly int n;

    static PS()
    {
        sw = new(new BufferedStream(Console.OpenStandardOutput()));
        dialogues = new[]
                    {"____",
                     "\"재귀함수가 뭔가요?\"",
                     "\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.",
                     "마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.",
                     "그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"",
                     "\"재귀함수는 자기 자신을 호출하는 함수라네\"",
                     "라고 답변하였지."};

        n = int.Parse(Console.ReadLine());
    }

    public static void Main()
    {
        sw.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");
        Recursive(0);

        sw.Close();
    }

    private static void Recursive(int count)
    {
        WriteUnderline(count);
        sw.WriteLine(dialogues[1]);

        if (count == n)
        {
            WriteUnderline(count);
            sw.WriteLine(dialogues[5]);
        }
        else
        {
            for (int i = 2; i <= 4; i++)
            {
                WriteUnderline(count);
                sw.WriteLine(dialogues[i]);
            }

            //재귀
            Recursive(count + 1);
        }

        WriteUnderline(count);
        sw.WriteLine(dialogues[6]);
    }

    private static void WriteUnderline(int count)
    {
        while (count-- > 0)
        {
            sw.Write(dialogues[0]);
        }
    }
}