﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Enter Number1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Number2: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if(Number1>Number2)
{
   Console.Write("Number1 > Number2: ");
   Console.Write(Number1);
   Console.Write(" > ");
   Console.WriteLine(Number2); 
}

else 
{
    if(Number1<Number2)
    {
        Console.Write("Number1 < Number2: ");
        Console.Write(Number1);
    Console.Write(" < ");
    Console.WriteLine(Number2);
    }
    else
    {
       Console.Write("Number1 = Number2: ");
        Console.Write(Number1);
    Console.Write(" = ");
    Console.WriteLine(Number2); 
    }
 
}