//Ветка была создана для выполнения основной задачи
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
Console.Clear();
Random random = new Random();

int ArrRandomSize()
{
    return random.Next(4, 7);
}

void ArrRandomElements(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine()!;
    }
}

string EndingString(int size)
{
    if(size <= 4) return "строки";
    else return "строк";
}

void ReducedArray(string[] arr)
{
    string[] newArr = new string[random.Next(0, 4)];
    int sizeNewArr = newArr.Length;
    System.Console.Write($"Вывод {sizeNewArr} строк: ");
    for (int i = 0; i < newArr.Length; i++)
    {
        
        string temp = arr[i];
        arr[i] = newArr[i];
        newArr[i] = temp;
        System.Console.Write($"[{newArr[i]}] ");
    }
}

int size = ArrRandomSize();
string[] arr = new string[size];
System.Console.WriteLine($"Введите {size} {EndingString(size)} через Enter");
ArrRandomElements(arr);
ReducedArray(arr);


