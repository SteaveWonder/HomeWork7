//Task 1.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Console.Write("Input quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] nums = new double[rows, columns];
// CreateRandomArray(nums);
// Show2dArray(nums);

// void CreateRandomArray(double[,] array)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(1, 50)) / 10;
//         }
//     }
// }
// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

//Task 2.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//1 , 7 -> числа с такими индексами в массиве нет.

Console.Write("Input number of rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of column: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[a, b];
CreateRandomArray(nums);
Show2dArray(nums);

int[,] CreateRandomArray(int[,] array)
{
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    Console.WriteLine();
}

if (a > nums.GetLength(0) || b > nums.GetLength(1))
{
    Console.WriteLine("There is no such element");
}
else
{
    Console.WriteLine($"Meaning of elements {a} row and {b} column equals: {nums[a - 1, b - 1]}");
}




//Task 3.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.Write("Input quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, columns];

// CreateRandomArray(array);
// Show2dArray(array);

// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         avarage = (avarage + array[i, j]);
//     avarage = avarage / rows;
//     Console.Write(avarage + "; ");
// }
// Console.WriteLine();


// int[,] CreateRandomArray(int[,] array)
// {
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     Console.WriteLine();
// }

