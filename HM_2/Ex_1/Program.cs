// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System;

class Program
{
    static int FunctionSecondNumber(int number)
    {
        int SecondDigit = (number / 10) % 10;
        return (SecondDigit);
    }
    static void Main(string[] args)
    {
        Console.Write("Введите 3х значное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int x;
        x = FunctionSecondNumber(number);
        Console.Write("Вторая цифра: " + x);
    }

}

