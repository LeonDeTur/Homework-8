// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

Console.WriteLine("Задан случайный двумерный массив:");
int m = new Random().Next(3,5);
int n = new Random().Next(3,5);

int[,] doubleArray = new int[m,n];
doubleArray = InputRandomNumbersInArray(doubleArray);
PrintDoubleArray(doubleArray);
Console.WriteLine("Сумма чисел строк двумерного массива");
int[] SumInLinesArray = CountSumInDoubleArrayLines(doubleArray);
PrintSumInLinesDoubleArray(SumInLinesArray);
Console.WriteLine();
Console.WriteLine($"№ строки с наибольшей суммой:{GetMaxSumIndexPlusOneFromArray(SumInLinesArray) + 1}");

// Методы

int[,] InputRandomNumbersInArray (int[,] doubleArray)
{
    for(int i = 0; i < m; i++)
    {
            for (int j = 0; j < n; j++)
        {
            doubleArray[i,j] = new Random().Next(1,9);
        }
    }
    return doubleArray;
}

void PrintDoubleArray(int[,] doubleArray)
{
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{doubleArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [] CountSumInDoubleArrayLines (int[,] doubleArray)
{
    int [] sumInLinesResults = new int[doubleArray.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum += doubleArray[i,j];
        }
        sumInLinesResults[i] = sum;
        sum = 0;
    }
    return sumInLinesResults;
}

void PrintSumInLinesDoubleArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write($"{i+1}-{array[i]} ");
    }
}

int GetMaxSumIndexPlusOneFromArray(int[] array)
{
    int max = 0;
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
            result = i;
        }
    }
    return result;
}

