// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

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
void PrintRepeats(int[,] matr)
{
    int[] counters = new int[10];

    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
           counters[matr[i,j]]++;
        }
    }
    for(int i =0; i < counters.Length; i++)
    {
        if (counters[i] > 0)
        {
            Console.WriteLine($"Элемент {i} повторяется {counters[i]} раз ");
        }
    }
}

int rowsCount = ReadInt("Введите число строк матриц");
int coloumnCount = ReadInt("Введите число столбцов матриц");
int[,] matrix = GetRandMatr(rowsCount, coloumnCount);
PrintMatr(matrix);
PrintRepeats(matrix);