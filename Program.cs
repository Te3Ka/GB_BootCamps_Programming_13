//Печать массива в консоль
void PrintArrayToConsole(int[] printArray)
{
    Console.Write("[");
    for (int i = 0; i < printArray.Length; i++)
    {
        if (i == printArray.Length - 1)
            Console.Write($"{printArray[i]}");
        else
            Console.Write($"{printArray[i]}, ");
    }
    Console.Write("]");
}

//Получение случайного числа
int GetRandomNumber(int min, int max)
{
    Random rnd = new Random();
    return rnd.Next(min, max + 1);
}

//Создание случайного массива
int[] GetRandomArray(int length)
{
    int[] randomArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        randomArray[i] = GetRandomNumber(-10, 25);
    }
    return randomArray;
}

int[] CountingSort(int[] sortArray)
{
    int max = sortArray.Max();
    int min = sortArray.Min();
    int offset = -min;

    int[] newArray = new int[sortArray.Length];
    int[] counters = new int[max + offset + 1];

    for (int i = 0; i < sortArray.Length; i++)
    {
        counters[sortArray[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            newArray[index] = i - offset;
            index++;
        }
    }
    return newArray;
}

int[] array = GetRandomArray(100);
Console.WriteLine("Изначальный массив:");
PrintArrayToConsole(array);
Console.WriteLine("\nМассив подсчёта элементов:");
PrintArrayToConsole(CountingSort(array));