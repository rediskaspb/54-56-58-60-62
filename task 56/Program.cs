// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandMatr(int rows, int columns, int leftRange = 0, int rightRange = 10)
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

int sumStringDig(int[,] matrix, int i)
{
    int sumString = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumString += matrix[i, j];
    }
    return sumString;
}

int rowsCount = ReadInt("Введите число строк");
int coloumnCount = ReadInt("Введите число столбцов");
int[,] matr = GetRandMatr(rowsCount, coloumnCount);
PrintMatr(matr);

int minSum = 0;
int sumString = sumStringDig(matr, 0);
for (int i = 1; i < matr.GetLength(0); i++)
{
    int SumLine = sumStringDig(matr, i);
    if (sumString > SumLine)
    {
        sumString = SumLine;
        minSum = i;
    }
}
Console.WriteLine($"Наименьшая сумма элементов в строке №{minSum + 1} = {sumString}");