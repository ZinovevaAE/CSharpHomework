Console.WriteLine("Задача 1: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].");
Console.WriteLine("Задача 2: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");
Console.WriteLine("Задача 3: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine("Задача 4: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("Задача 5: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");

Console.Write("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());

if (task == 1)
{
    //Задача 35: Задайте одномерный массив из 123 случайных чисел. 
    // Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

    int[] array = new int[123];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 999);
        if (array[i] >= 10 && array[i] <= 99) count++;

        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
    Console.WriteLine("count = " + count);
}

if (task == 2)
{
    //Задача 37: Найдите произведение пар чисел в одномерном массиве. 
    //Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

    int[] array = new int[5];
    int[] result = new int[Convert.ToInt32(Math.Round((Convert.ToDouble(array.Length) / 2)))];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");


    for (int i = 0; i < array.Length; i++)
    {
        if (i == result.Length) break;
        result[i] = array[i] * array[(array.Length - i - 1)];

        Console.Write(result[i] + " ");
    }
}

if (task == 3)
{
    // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    // [345, 897, 568, 234] -> 2
    int[] array = new int[10];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0) count++;

        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
    Console.WriteLine("Количество четных значений: " + count);
}

if (task == 4)
{
    // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    // [3, 7, 23, 12] -> 19
    // [-4, -6, 89, 6] -> 0
    int[] array = new int[4];
    int Sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        if (i % 2 == 0) Sum += array[i];

        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
    Console.WriteLine("Сумма элементов, стоящих на нечетной позиции: " + Sum);
}

if (task == 5)
{
    // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    // [3 7 22 2 78] -> 76
    int[] array = new int[10];
    int diff = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i] + " ");
    }

    int max = array[0];
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (array[i] < min) min = array[i];

    }
    Console.WriteLine(" ");
    Console.WriteLine("max = " + max + " min = " + min);
    Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + (max - min));
}