// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    return array;
}
int[] array = GetArray(4, -9, 9);
Console.WriteLine();
void reverse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
        Console.Write($"{array[i]} ");
    }
}
reverse(array);