// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Задан случайный двумерный массив:");

int m = new Random().Next(3,5);
int n = new Random().Next(3,5);
int k = new Random().Next(3,5);

int[,] doubleArray1 = new int[m,n];
doubleArray1 = InputRandomNumbersInArray(doubleArray1);
PrintArray(doubleArray1);


Console.WriteLine();

int[,] doubleArray2 = new int[n,k];
doubleArray2 = InputRandomNumbersInArray(doubleArray2);
PrintArray(doubleArray2);

Console.WriteLine();

int [,] result = CountResult(doubleArray1, doubleArray2);
PrintArray(result);


// Методы

int[,] InputRandomNumbersInArray (int[,] doubleArray)
{
    for(int i = 0; i < doubleArray.GetLength(0); i++)
    {
            for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            doubleArray[i,j] = new Random().Next(1,9);
        }
    }
    return doubleArray;
}

int[,] CountResult (int [,] firstTable, int[,] secondTable)
{
    int[,] resultTable = new int[firstTable.GetLength(0),secondTable.GetLength(1)];
    for (int i = 0; i < firstTable.GetLength(0); i ++)
    {
        for (int j = 0; j < secondTable.GetLength(1); j++)
        {
            resultTable[i,j] = 0;
            for (int k = 0; k < firstTable.GetLength(0); k++)
            {
                resultTable[i,j] = resultTable[i,j] + firstTable[i,k] * secondTable[k,j];
            }
        }
    }
    return resultTable;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
