Console.Clear();
string [] stingArray = new string[4];

string[] FillArray (string[] arr)
{
    Console.WriteLine("Введите элементы массива!");
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите элемент: ");
        string element = Convert.ToString(Console.ReadLine());
        arr[i] = element;
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.WriteLine("Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

string [] newArray = FillArray(stingArray);
PrintArray(newArray);

void DeleteTheLastElement(string[] arr)
{
    Console.WriteLine();
    Console.WriteLine("Новый массив: ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

DeleteTheLastElement(newArray);