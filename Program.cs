
Random random = new Random();

int ArrRandomSize()
{
    return random.Next(0, 4);
}
void ArrElements(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine()!;
    }
}



string[] arr = new string[ArrRandomSize()];
// ArrRandomElements(arr);
// ArrPrint(arr);
