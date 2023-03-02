/*:Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
*/

Console.Clear();

void PrintArray(int[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}
 
int[] InputIntArray()
{
    Console.Write("Введите массив чисел через пробел: ");
    string line = Console.ReadLine();
    string[] nums = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        array[i] = int.Parse(nums[i]);
    }
    return array;
}

int[] ProductOfNumbers(int[] arr)
{
    int arrLen = arr.Length;
    int resultLen = (arrLen + 1) / 2;
    int[] result = new int[resultLen];
    for (int i = 0; i < resultLen - 1; i++) 
        result[i] = arr[i] * arr[arrLen - 1 - i];
    if (arrLen % 2 == 1) result[resultLen - 1] = arr[resultLen - 1];
    else result[resultLen - 1] = arr[resultLen - 1] * arr[resultLen];
    return result;
}

int[] numbers = InputIntArray();
PrintArray(ProductOfNumbers(numbers));