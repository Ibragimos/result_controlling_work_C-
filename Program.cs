
Random random = new Random();

int ArrRandomSize()
{
    return random.Next(0, 4);
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


string[] arr = new string[ArrRandomSize()];
ArrRandomElements(arr);
ArrPrint(arr);
