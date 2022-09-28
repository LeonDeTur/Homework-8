// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int size = 2;
int[,,] trisomeArray = new int[size,size,size];
trisomeArray = InputInArrayUnicNums(trisomeArray);
PrintTrisomeArray(trisomeArray);

// Методы

void PrintTrisomeArray (int[,,]threeSizeArray)
{
    for (int i = 0; i < threeSizeArray.GetLength(0);i++)
    {
        for (int j = 0; j < threeSizeArray.GetLength(1);j++)
        {
            for (int k = 0; k < threeSizeArray.GetLength(2);k++)
            {
                if (threeSizeArray[i,j,k] > 0)
                {
                    Console.Write($" {threeSizeArray[i,j,k]}({i},{j},{k}) ");
                }
                else
                {
                    Console.Write($"{threeSizeArray[i,j,k]}({i},{j},{k}) ");
                }
            }
            Console.WriteLine();
        }
    }
}

bool CheckUnicNum (int[,,] threeSizeArray, int num)
{
    for (int i = 0; i < threeSizeArray.GetLength(0);i++)
    {
        for (int j = 0; j < threeSizeArray.GetLength(1);j++)
        {
            for (int k = 0; k < threeSizeArray.GetLength(2);k++)
            {
                if (threeSizeArray[i,j,k] == num)
                {
                    return false;
                }
            }
        }
    }
    return true;
}

int [,,] InputInArrayUnicNums (int[,,]threeSizeArray)
{
    for (int i = 0; i < threeSizeArray.GetLength(0);i++)
    {
        for (int j = 0; j < threeSizeArray.GetLength(1);j++)
        {
            for (int k = 0; k < threeSizeArray.GetLength(2);k++)
            {
                threeSizeArray[i,j,k] = CreateUnicNumber(threeSizeArray);
            }
        }
    }
    return threeSizeArray;
}

int CreateUnicNumber (int [,,] threeSizeArray)
{
    Random rnd = new Random();
    int input = rnd.Next(1, 3)==1 ? rnd.Next(-99, 9) : rnd.Next(10,100);
    if (CheckUnicNum(threeSizeArray, input) != true)
    {
        CreateUnicNumber(threeSizeArray);
    }
    return input;
}