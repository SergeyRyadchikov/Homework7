// Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном
// массиве, и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
// 4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
// 2, 3 -> такой элемент есть и равен 4
// 5, 5 -> такой элемент отсутствует

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

void SeachingElementsOrIndex(int[,] matrix, string[] massive)
{
    if (massive.Length == 1)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == Convert.ToInt32(massive[0]))
                {
                    Console.WriteLine($"Элемент найден на позиции {i}, {j}");
                    count++;
                }
            }
        }
        if (count == 0) Console.WriteLine("Такого элемента не найдено");
    }
    else if (massive.Length == 2)
    {
        if (Convert.ToInt32(massive[0]) > matrix.GetLength(0) ||
             Convert.ToInt32(massive[1]) > matrix.GetLength(1))
        {
            Console.WriteLine("Нет элемента с таким индексом");
        }
        Console.WriteLine("Элемент на указанной позиции = " +
                          $"{matrix[Convert.ToInt32(massive[0]), Convert.ToInt32(massive[1])]}");
    }
    else Console.WriteLine("Введите одно или два числа через запятую");
}

Console.WriteLine("Введите размерность массива через запятую: ");
string size = Console.ReadLine();
string[] array = size.Split(",");
int[,] massive = new int[Convert.ToInt32(array[0]), Convert.ToInt32(array[1])];

FillMatrix(massive);
PrintMatrix(massive);
Console.WriteLine();

Console.WriteLine("Введите значение или индекс элемента, который нужно найти: ");
string value = Console.ReadLine();
string[] mass = value.Split(",");
SeachingElementsOrIndex(massive, mass);

