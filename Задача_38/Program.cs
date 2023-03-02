/*Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
Console.Clear();

double[] InputDoubleArray()
{
    Console.Write("Введите массив чисел через пробел: ");
    string line = Console.ReadLine();
    string[] nums = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] array = new double[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        array[i] = double.Parse(nums[i]);
    }
    return array;
}

double ArrayAmplitude(double[] arr)
{
    double maxValue = arr[0], minValue = arr[0];
    foreach (double number in arr) 
        {
            if (number > maxValue) maxValue = number;
            else if (number < minValue) minValue = number;
        }
    
    return maxValue - minValue;
}

double[] numbers = InputDoubleArray();
Console.WriteLine($"Разница между максимальным и минимальным значением равна {ArrayAmplitude(numbers)}");