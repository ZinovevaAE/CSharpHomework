//Задача1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void FuncPalindrome(string number)
{
    if (number[0] == number[4])
    {
        if (number[1] == number[3]) Console.WriteLine("Это палиндром");
        else Console.WriteLine("Это не палиндром");
    }
    else Console.WriteLine("Это не палиндром");
}

Console.WriteLine("Задача1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

Console.Write("Введите 5-значное число: ");
string Z = Console.ReadLine();
FuncPalindrome(Z);



//Задача2. Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double FuncLengthAB(int[] pointA, int[] pointB)
{
    
    Console.WriteLine("Координаты точки А: (" + pointA[0]+", "+pointA[1]+", "+pointA[2]+")" );
    Console.WriteLine("Координаты точки А: (" + pointB[0]+", "+pointB[1]+", "+pointB[2]+")" );
    double LengthAB = Math.Sqrt(Math.Pow((pointA[0] - pointB[0]), 2) + Math.Pow((pointA[1] - pointB[1]), 2) + Math.Pow((pointA[2] - pointB[2]), 2));

    return Math.Round(LengthAB, 2);
}

Console.WriteLine("");
Console.WriteLine("Задача2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
int[] A = { 7, -5, 0 };
int[] B = { 1, -1, 9 };

double LengthAB = FuncLengthAB (A, B);
Console.WriteLine("Расстояние между двумя точками = " + LengthAB);




//Задача3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
void FuncToThe3Pow(int N)
{
    Console.WriteLine("N = " + N);

    for (int i = 1; i < N; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.Write(Math.Pow(N, 3) + ".");
}

Console.WriteLine("");
Console.WriteLine("Задача3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
int N = new Random().Next(1, 20);
FuncToThe3Pow(N);