// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillRandomNumbers(int[] arr, int from, int to)
{
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(from, to);
    }
}

void PrintNums(int[] arr)
{
    foreach (int el in arr)
    {
        Console.Write(el + " ");
    }
    Console.WriteLine();
}

int CountFromTo(int[] arr, int from, int to)
{
    int count = 0;

    foreach (int val in arr)
    {
        if (val >= from && val <= to)
        {
            count++;
        }
    }

    return count;
}

int[] arr = new int[123];

FillRandomNumbers(arr, 0, 200);
PrintNums(arr);

int from = 10, to = 99;
int countFromTo = CountFromTo(arr, from, to);

Console.WriteLine($"Чисел с {from}, до {to} = {countFromTo}");