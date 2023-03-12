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
        randomArray[i] = GetRandomNumber(0, 9);
    }
    return randomArray;
}

int[] CountingSort(int[] sortArray)
{
    int[] newArray = new int[sortArray.Length];
    int[] counters = new int[10];

    for (int i = 0; i < sortArray.Length; i++)
    {
        counters[sortArray[i]]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            newArray[index] = i;
            index++;
        }
    }
    return newArray;
}

int[] array = GetRandomArray(50);
Console.WriteLine("Изначальный массив:");
PrintArrayToConsole(array);
Console.WriteLine("\nМассив подсчёта элементов:");
PrintArrayToConsole(CountingSort(array));