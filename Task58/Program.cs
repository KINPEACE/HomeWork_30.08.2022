// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine($"Введите размеры матриц и диапазон случайных значений:");
int m = WriteNumbers("Введите число строк 1-й матрицы: ");
int n = WriteNumbers("Введите число столбцов 1-й матрицы и строк 2-й: ");
int p = WriteNumbers("Введите число столбцов 2-й матрицы: ");
int range = WriteNumbers("Введите диапазон случайных чисел: от 1 до ");
Console.WriteLine();
int[,] firstMatrix = new int[m, n];
Create(firstMatrix);
Console.WriteLine($"Первая матрица:");
Show(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = new int[n, p];
Create(secondMatrix);
Console.WriteLine($"Вторая матица:");
Show(secondMatrix);
Console.WriteLine();
int[,] resultMatrix = new int[m, p];
Multi(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
Show(resultMatrix);

void Multi(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for(int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for(int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int WriteNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void Create(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void Show(int[,] array)
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
