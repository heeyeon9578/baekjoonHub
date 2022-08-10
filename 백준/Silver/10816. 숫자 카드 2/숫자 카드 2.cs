using System.Text;

int myCardCount = int.Parse(Console.ReadLine());
string[] myCard = Console.ReadLine().Split(" ");
int qCardCount = int.Parse(Console.ReadLine());
string[] qCard = Console.ReadLine().Split(" ");

List<int> intMyCard = new List<int>();
List<int> intQCard = new List<int>();

for (int i = 0; i < myCardCount; i++)
{
    intMyCard.Add(int.Parse(myCard[i]));
}

for (int i = 0; i < qCardCount; i++)
{
    intQCard.Add(int.Parse(qCard[i]));
}

intMyCard.Sort();
//이진 탐색
int MyBinarySerch (List<int> arr, int n, int target, bool search)
{
    int left = 0, right = n - 1;
    int result = -1; //거짓인 경우 -1을 리턴

    while (left <= right)
    {
        int mid = (left + right) / 2;

        if (target == arr[mid])
        {
            result = mid;

//중복을 찾기위한 여정
            if (search) // true인 경우 같은값의 가장 앞에 인덱스를 찾음
            {
                right = mid - 1;
            }
            else // false인 경우 같은값의 가장 뒤에 인덱스를 찾음
            {
                left = mid + 1;
            }
        }
        else if (target < arr[mid])
        {
            right = mid - 1;
        }
        else
        {
            left = mid + 1;
        }
    }
    return result;
}

StringBuilder sb = new StringBuilder();
for (int i = 0; i < qCardCount; i++)
{
    int first = MyBinarySerch(intMyCard, myCardCount, intQCard[i], true);
    int last = MyBinarySerch(intMyCard, myCardCount, intQCard[i], false);


    if (first != -1)
    {
        sb.Append(last - first + 1);
        sb.Append(" ");
    }
    else
    {
        sb.Append(0);
        sb.Append(" ");
    }
}


Console.WriteLine(sb);