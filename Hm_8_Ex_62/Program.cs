// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int size = 4;
int[,] doubleArray = new int[size,size];
InputThreeSizeArraySpirally(doubleArray,0,0);
PrintArray(doubleArray);
// Методы

void InputThreeSizeArraySpirally (int [,] twoSizeArray, int tmp1, int tmp2)
{
    for (int j = tmp2; j < twoSizeArray.GetLength(1) && twoSizeArray[tmp1,j] == 0; j++)
    {
        twoSizeArray[tmp1,j] = new Random().Next(1,10);
        tmp2 = j;
        PrintArray(twoSizeArray);
        Console.WriteLine();
    }
    tmp1++;
    for (int i = tmp1; i < twoSizeArray.GetLength(0) && twoSizeArray[i,tmp2] == 0; i++)
    {
        twoSizeArray[i,tmp2] = new Random().Next(1,10);
        tmp1 = i;
        PrintArray(twoSizeArray);
        Console.WriteLine();
    }
    tmp2--;
    for (int j = tmp2; j > -1 && twoSizeArray[tmp1,j] == 0; j--)
    {
        twoSizeArray[tmp1,j] = new Random().Next(1,10);
        tmp2 = j;
        PrintArray(twoSizeArray);
        Console.WriteLine();
    }
    tmp1--;
    for (int i = tmp1; i > 0 && twoSizeArray[i,tmp2] == 0; i--)
    {
        twoSizeArray[i,tmp2] = new Random().Next(1,10);
        tmp1 = i;
        PrintArray(twoSizeArray);
        Console.WriteLine(tmp1 + " " + tmp2);
    }
    if (twoSizeArray[tmp1,tmp2+1] == 0)
    {
        InputFrameThreeSizeArraySpirally(twoSizeArray, tmp1, tmp2+1);
    }
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
