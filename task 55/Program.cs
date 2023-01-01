// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] GetRandArray(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] array = new int[rows, columns];
    var rand = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] array)
{
    int[,] arr = new int[array.GetLength(1), array.GetLength(0)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            arr[j, i] = array[i, j];
        }
    }
    return arr;
}

int rowsCount=4;
int coloumnCount=4;
int[,] array = GetRandArray(rowsCount, coloumnCount);
PrintArray(array);
int[,] arr = ChangeArray(array);
Console.WriteLine();
PrintArray(arr);