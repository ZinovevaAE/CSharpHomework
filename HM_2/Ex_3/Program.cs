// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите цифру от 1 до 7, где 1 обозначает понедельник, 2 - вторник, ..., 7 - воскресение: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Это выходной? ");
if (number == 6) Console.Write("Да");
else 
    if (number == 7) Console.Write("Да");
    else Console.Write("Нет");
