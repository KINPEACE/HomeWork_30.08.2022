// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

Console.WriteLine($"Введите размер массива m x n и диапазон случайных значений: ");
int m = WriteNumbers("Введите кол-во строк m: ");
int n = WriteNumbers("Введите кол-во столбцов n: ");
int range = WriteNumbers("Введите диапазон от 1 до ...: ");
Console.WriteLine();
Console.WriteLine($"Неотсортированный массив: ");

int[,] array = new int[m, n];

void ArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int tmp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = tmp;
                }
            }
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

Create(array);
Show(array);
Console.WriteLine();
Console.WriteLine($"Отсортированный массив: ");
ArrayLines(array);
Show(array);
