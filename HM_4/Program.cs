Console.WriteLine("Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Задача 3: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.");
Console.Write("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());

if (task == 1)
{
    //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    //3, 5 -> 243 (3⁵)

    int numberA = new Random().Next(1, 10);
    int numberB = new Random().Next(1, 10);
    int result = numberA;

    for (int i = 1; i < numberB; i++)
    {
        result = result * numberA;
    }

    Console.WriteLine($"A= {numberA}, B= {numberB}, A^B= {result} ");
}
else if (task == 2)
{
    //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    //452 -> 11

    Console.WriteLine("Введите число: ");
    string number = Console.ReadLine();
    int Sum = 0;
    int NumberInt = Convert.ToInt32(number);

    for (int i = 0; i < number.Length - 1; i++)
    {
        Sum = Sum + NumberInt % 10;
        NumberInt = NumberInt / 10;
    }

    Sum += NumberInt;
    Console.WriteLine("Сумма цифр: " + Sum);

}
else if (task == 3)
{
    //Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
    //1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    //6, 1, 33 -> [6, 1, 33]

    Console.WriteLine("Введите массив чисел через пробел: ");
    string input = Console.ReadLine();
    string[] elements = input.Split(" ");
    int[] array = new int[elements.Length];

    for (int i = 0; i < elements.Length; i++)
    {
        array[i] = Convert.ToInt32(elements[i]);
    }

    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }

    Console.WriteLine(array[array.Length - 1] + "]");
}





