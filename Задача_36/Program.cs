/*Задайте одномерный массив,
заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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

int SumOddIndex(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2) 
        sum += arr[i];
    return sum;
}

int size = DataInput("Введите размер массива");
int minNumber = DataInput("Введите минимальное число");
int maxNumber = DataInput("Введите максимальное число");
int[] array = CreateIntArray(size, minNumber, maxNumber);
PrintArray(array);
Console.WriteLine($"Сумма элементов на нечетных позициях равна {SumOddIndex(array)}");
