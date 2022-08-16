// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + "\t");

        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }
}

void ArithmeticMeanOfColumns(int[,] mass)
{
    double res = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            res += mass[i, j];
        }
        res = res / mass.GetLength(0);
        Console.WriteLine($"Среднее арифметическое стобца {j + 1} = {Math.Round(res, 1)}");
        res = 0;
    }
}

Console.WriteLine("Введите размерность массива через запятую: ");
string size = Console.ReadLine();
string[] mass = size.Split(",");
int[,] massive = new int[Convert.ToInt32(mass[0]), Convert.ToInt32(mass[1])];

FillMatrix(massive);
PrintMatrix(massive);
ArithmeticMeanOfColumns(massive);