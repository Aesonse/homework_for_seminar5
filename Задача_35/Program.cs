/* Задайте одномерный массив из 123 случайных чисел [0: 1000].
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*/
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

int CountInInterval(int[] arr, int minValue, int maxValue)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= minValue && arr[i] <= maxValue) count++;
    }
    return count;
}

int[] array = CreateIntArray(123, 0, 1001);
PrintArray(array);
Console.WriteLine($"В данном массиве {CountInInterval(array, 10, 99)} двухзначных чисел");

