// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.WriteLine("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

void OutputNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        OutputNumbers(m + 1, n);
    }
}

OutputNumbers(m, n);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n, int sum)
{
    if (m <= n)
        return Sum(m + 1, n, sum + m);
    return sum;
}
Console.WriteLine($"Сумма элементов = {Sum(m + 1, n, m)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int FuncAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FuncAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
    return 0;
}
Console.WriteLine($"Функция Аккермана для m={m} и n={n} имеет значение: { FuncAkkerman(m, n)}");
