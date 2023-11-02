
Console.Clear();
Random random = new Random();

int ArrRandomSize()
{
    return random.Next(3, 6);
}

void ArrRandomElements(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine()!;
    }
}

void ArrPrint(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}

string EndingString(int size)
{
    if(size <= 4) return "строки";
    else return "строк";
}

int size = ArrRandomSize();
string[] arr = new string[size];
System.Console.WriteLine($"Введите {size} {EndingString(size)} через Enter");
ArrRandomElements(arr);
