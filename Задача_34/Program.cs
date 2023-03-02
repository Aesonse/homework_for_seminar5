/*Задайте массив заполненный
случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.*/

Console.Clear();

int DataInput(string message)
{
    Console.Write(message + ": ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

void PrintArray(int[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}
 
int[] CreateIntArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

int CountEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int size = DataInput("Введите размер массива");
int[] array = CreateIntArray(size, 100, 1000);
PrintArray(array);
Console.WriteLine($"В данном массиве {CountEven(array)} четных элементов");