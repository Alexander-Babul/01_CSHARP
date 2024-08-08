void ZeroEvenElement(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] Array = { 1, 3, 6, 8, 9, 8, 8 };

ZeroEvenElement(Array);
PrintArray(Array);