// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateMatrix(int m, int n)
{
    int[,] numbers = new int[m, n];

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
    return numbers;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Матрица: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
    return array;
}

int[,] numbers = CreateMatrix(3, 4);
PrintMatrix(numbers);

void SortMatrix(int[,] numbers)
{
    int[] row = new int[numbers.GetLength(1)];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            row[j] = numbers[i, j];
        }
        row = SortArray(row);
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = row[j];
        }
    }
}
SortMatrix(numbers);
PrintMatrix(numbers);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int RowWithMinSum(int[,] numbers)
{
    int[] SumRow = new int[numbers.GetLength(1)];
    int min = 40;
    int minIndex = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            SumRow[i] += numbers[i, j];
        }
        if (SumRow[i] < min)
        {
            min = SumRow[i];
            minIndex = i;
        }
    }
    return minIndex;
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {RowWithMinSum(numbers)}");






// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] ProductTwoMatrix(int[,] matr1, int[,] matr2)
{
    int[,] result = new int[matr1.GetLength(0), matr2.GetLength(1)];
    if (matr1.GetLength(1) == matr2.GetLength(0))
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int k = 0; k < result.GetLength(1); k++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    result[i, k] += matr1[i, j] * matr2[j, k];
                }
            }
        }
    }
    else Console.WriteLine("Для указанных матриц произведение нельзя посчитать.");
    return result;
}

int[,] matrix1 = CreateMatrix(2, 3);
int[,] matrix2 = CreateMatrix(3, 2);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
Console.WriteLine("Произведение матриц выше: ");
PrintMatrix(ProductTwoMatrix(matrix1, matrix2));


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Create3DArray(int m, int n, int k)
{
    int[,,] array3D = new int[m, n, k];
    int start = 10;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        start += i;
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            start += j;
            for (int l = 0; l < array3D.GetLength(2); l++)
            {
                start += l;
                array3D[i, j, l] = start;
            }
        }

    }
    return array3D;
}

void Write3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int l = 0; l < array3D.GetLength(2); l++)
            {
                Console.Write($"{array3D[i, j, l]} ({i}, {j}, {l})  ");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }
}

int[,,] Shuffle(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int l = 0; l < array3D.GetLength(2); l++)
            {
                int temp = new Random().Next(0, l + 1);
                int tempEl = array3D[i, j, temp];
                array3D[i, j, temp] = array3D[i, j, l];
                array3D[i, j, l] = tempEl;
            }
        }
    }
    return array3D;
}

int[,,] array3D = Create3DArray(2, 4, 3);
Console.WriteLine("");
Console.WriteLine("Трехмерный массив двузначных чисел: ");
// Write3DArray(array3D);
// Console.WriteLine("");
Write3DArray(Shuffle(array3D));

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] arr = new int[4, 4];
int number = 1;
for (int i = 0; i < 4; i++)
{
    arr[0, i] = number;
    number++;
}
for (int i = 1; i < 4; i++)
{
    arr[i, 3] = number;
    number++;
}
for (int i = 2; i >= 0; i--)
{
    arr[3, i] = number;
    number++;
}
for (int i = 2; i > 0; i--)
{
    arr[i, 0] = number;
    number++;
}

for (int i = 1; i < 3; i++)
{
    arr[1, i] = number;
    number++;
}
for (int i = 2; i > 0; i--)
{
    arr[2, i] = number;
    number++;
}

Console.WriteLine("Спирально заполненная матрица: ");
PrintMatrix(arr);
