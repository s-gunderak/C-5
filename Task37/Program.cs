// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}
int[] array = GetArray(17, 0, 9);

for (int i = 0; i < (array.Length + 1) / 2; i++)
{
    if (i != (array.Length - 1 - i))
    {
        int prod = array[i] * array[array.Length - 1 - i];
        Console.Write($"{prod} ");
    }
    else
    {
        Console.Write(array[i]);
    }
}