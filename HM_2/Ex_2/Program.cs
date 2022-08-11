//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void FuncDigit3Find(string Number)
{
    int n = Number.Length;
    int number = Convert.ToInt32(Number);

    int[] digitsArr = new int[n];
    int i = 0;

    while (i < n)
    {
        digitsArr[i] = number % 10;
        number = number / 10;
        i++;
    }

    if (n < 3) Console.WriteLine("Третьей цифры нет");
    else Console.WriteLine("Третья цифра: " + digitsArr[n - 3]);
}

Console.Write("Введите число: ");
string Number = Console.ReadLine();

FuncDigit3Find(Number);

