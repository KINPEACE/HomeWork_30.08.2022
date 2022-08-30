// Сформируйте трехмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

Console.WriteLine($"Введите размер массива X x Y x Z:");
int m = WriteNumbers("Введите X: ");
int n = WriteNumbers("Введите Y: ");
int p = WriteNumbers("Введите Z: ");
Console.WriteLine($" ");

int[,,] array = new int[m, n, p];
Create(array);
Show(array);

int WriteNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void Show(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"Z({k}) = {array[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void Create(int[,,] array)
{
    int[] tmp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int num;
    for(int i = 0; i < tmp.GetLength(0); i++)
    {
        tmp[i] = new Random().Next(10, 100);
        num = tmp[i];
        if(i >= 1)
        {
            for(int j = 0; j < i; j++)
            {
                while(tmp[i] == tmp[j])
                {
                    tmp[i] = new Random().Next(10, 100);
                    j = 0;
                    num = tmp[i];
                }
                num = tmp[i];
            }
        }
    }
    int count = 0;
    for(int m = 0; m < array.GetLength(0); m++)
    {
        for(int n = 0; n < array.GetLength(1); n++)
        {
            for(int p = 0; p < array.GetLength(2); p++)
            {
                array[m, n, p] = tmp[count];
                count++;
            }
        }
    }
}
