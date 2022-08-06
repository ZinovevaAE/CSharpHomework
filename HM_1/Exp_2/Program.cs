//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int number1 = new Random().Next(-11, 10);
int number2 = new Random().Next(-11, 10);
int number3 = new Random().Next(-11, 10);

Console.WriteLine(number1);
Console.WriteLine(number2);
Console.WriteLine(number3);

int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

Console.Write("max = ");
Console.WriteLine(max);