// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("Введите М чисел через пробел: ");
string input = Console.ReadLine();
string[] array = input.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
int M = array.Length;
int count = 0;

for (int i = 0; i < M; i++)
{
    if (int.Parse(array[i]) > 0) count++;
}
Console.WriteLine("Количество чисел больше нуля: " + count);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Console.WriteLine("Введите значения.");
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine());

double IntersectionX = (b1 - b2) / (k2 - k1);
double IntersectionY = (b1 * k2 - b2 * k1) / (k2 - k1);

Console.WriteLine("Точка пересечения: (" + IntersectionX + "; " + IntersectionY + ")");


