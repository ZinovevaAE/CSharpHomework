// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размер массива m*n ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        // array[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;
        array[i, j] = Math.Round(new Random().NextDouble(), 2);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите позицию элемента (i,j) в двумерном массиве ");
int posI = int.Parse(Console.ReadLine());
int posJ = int.Parse(Console.ReadLine());

if (posI >= array.GetLength(0) || posJ >= array.GetLength(1))
            Console.WriteLine("Элемента с такой позицией в массиве нет.");
else Console.WriteLine(array[posI, posJ]);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] numbers = new int[3, 3];
double[] average = new double[numbers.GetLength(1)];

Console.WriteLine("Задана матрица: ");
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(0, 10);
        Console.Write(numbers[i, j] + " ");
        average[j] += Convert.ToDouble(numbers[i, j]) / numbers.GetLength(0);
    }
    Console.WriteLine("");
}
Console.WriteLine("Среднее арифметическое столбца: ");
for (int j = 0; j < numbers.GetLength(1); j++)
{
    Console.Write(Math.Round(average[j], 1) + " ");
}