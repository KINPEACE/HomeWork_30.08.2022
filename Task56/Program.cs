// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine($"Введите размер массива m x n и диапазон случайных значений:");
int m = WriteNumbers("Введите кол-во строк m: ");
int n = WriteNumbers("Введите кол-во столбцов n: ");
int range = WriteNumbers("Введите диапазон от 1 до ...: ");

int[,] array = new int[m, n];
Create(array);
Show(array);

int minLine = 0;
int sumNum = Elements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tmp = Elements(array, i);
  if (sumNum > tmp)
  {
    sumNum = tmp;
    minLine = i;
  }
}

Console.WriteLine($"{minLine + 1} - строкa с минимальной суммой ({sumNum}) элементов ");


int Elements(int[,] array, int i)
{
  int sumNum = array[i, 0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumNum += array[i, j];
  }
  return sumNum;
}

int WriteNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void Create(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void Show (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
