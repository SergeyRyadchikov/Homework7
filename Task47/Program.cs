// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5     7     -2      -0,2
//  1    -3,3     8      -9,9
//  8     7,8   -7,1       9


void PrintMatrixRealNumbers(double[,] array)
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

void FillMatrixRealNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                array[i, j] = Math.Round((new Random().NextDouble() * 9) + (-2), 1);
            }
        }
    }
}



Console.WriteLine("Введите размерность массива через запятую: ");
string size = Console.ReadLine();
string[] mass = size.Split(",");
double[,] massive = new double[Convert.ToInt32(mass[0]), Convert.ToInt32(mass[1])];

FillMatrixRealNumbers(massive);
PrintMatrixRealNumbers(massive);
