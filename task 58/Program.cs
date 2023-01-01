// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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
int[,] MatrProd(int[,] matr, int[,] matr1)
{
    int[,] resultMatr = new int[matr.GetLength(0), matr1.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            resultMatr[i, j] += matr[i, j] * matr1[i, j];
        }
    }
    return resultMatr;
}
int rowsCount = ReadInt("Введите число строк матриц");
int coloumnCount = ReadInt("Введите число столбцов матриц");
// int rowsCount2 = ReadInt("Введите число строк матрицы2");
// int coloumnCount2 = ReadInt("Введите число столбцов матрицы2");
int[,] matr = GetRandMatr(rowsCount, coloumnCount);
PrintMatr(matr);
Console.WriteLine();
int[,] matr1 = GetRandMatr(rowsCount, coloumnCount);
PrintMatr(matr1);
Console.WriteLine("Произведение двух матриц равно: ");
int[,] result = MatrProd(matr, matr1);
PrintMatr(result);