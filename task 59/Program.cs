// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandMatr(int rows, int columns, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rows, columns];

    var rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatr(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] DeleteMinElem(int [,] sourceMatrix)
{
    int min = sourceMatrix[0, 0];
    int mini = 0;
    int minj = 0;

    for(int i = 0; i < sourceMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < sourceMatrix.GetLength(1); j++)
        {
            if (sourceMatrix[i, j] < min)
            {
                mini = i;
                minj = j;
                min = sourceMatrix[i,j];
            }
        }
    }
    int[,] newMatrix = new int[sourceMatrix.GetLength(0)-1, sourceMatrix.GetLength(1)-1];
    int rowoffset = 0;
    int coloumnoffset = 0;
    for(int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == mini) rowoffset = 1;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j == minj) coloumnoffset = 1;
            newMatrix[i,j] = sourceMatrix[i + rowoffset, j + coloumnoffset];
        }
        coloumnoffset = 0;
    }
    return newMatrix;
}

int rowsCount = ReadInt("Введите число строк");
int coloumnCount = ReadInt("Введите число столбцов");

int[,] matr = GetRandMatr(rowsCount, coloumnCount);
PrintMatr(matr);
Console.WriteLine();
int[,] result = DeleteMinElem(matr);
PrintMatr(result);
