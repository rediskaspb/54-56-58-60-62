// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

void ChangeArray(int[,] array)
{
    int temp=0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        temp=array[0, j];
        array[0,j] = array[array.GetLength(0)-1, j];
        array[array.GetLength(0)-1, j] = temp;
    }

}

int rowsCount=3;
int coloumnCount=4;
int[,] array = GetRandArray(rowsCount, coloumnCount);
PrintArray(array);
ChangeArray(array);
Console.WriteLine();
PrintArray(array);