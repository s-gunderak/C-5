// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
int[] array = GetArray(5, 0, 350);

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

bool FindElement(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }
    }
    return false;
}
if (FindElement(array, num) == true)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
