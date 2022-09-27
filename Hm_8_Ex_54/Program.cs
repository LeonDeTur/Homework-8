// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = new Random().Next(3,5);
int n = new Random().Next(3,5);

int[,] doubleArray = new int[m,n];
doubleArray = InputRandomNumbersInArray(doubleArray);
doubleArray = RangeArrayFromMax(doubleArray);

PrintDoubleArray(doubleArray);

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

int[,] RangeArrayFromMax (int[,] doubleArray)
{
    for(int i = 0; i < m; i++)
    {
        for (int count = 0; count < n; count++)
        {
            for (int j = 1; j < n; j++)
            {
                if (doubleArray[i,j-1] < doubleArray[i,j])
                {
                    int temp = doubleArray[i,j];
                    doubleArray[i,j] = doubleArray[i,j-1];
                    doubleArray[i,j-1] = temp;
                    j = 1;
                } 
            }
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