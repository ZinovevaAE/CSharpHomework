// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int number = new Random().Next(-20, 30);

Console.WriteLine(number);

if ((number % 2) == 0)
{
    Console.WriteLine("This is an even number");
}
else
{
    Console.WriteLine("This is an uneven number");
}