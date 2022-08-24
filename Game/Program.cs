int[,] number = { {0,0,0,0,0,0,0},
                  {0,0,0,0,2,0,0},
                  {0,0,0,0,2,0,0},
                  {0,0,0,1,2,0,0},
                  {0,3,0,0,0,0,0},
                  {0,0,0,0,0,0,0}};

// 1 - игрок    
// 2 - стена
// 3 - рандомный фрукт, собрать - увеличивается кол-во очков. 

int row = 3;
int column = 3;
int oldRow = 0;
int oldColumn = 0;
int score = 0;

int row3 = 0;
int column3 = 0;


while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    number[row, column] = 0;
    oldRow = row;
    oldColumn = column;
    if (key.Key == ConsoleKey.W)
    {
        row--;
    }
    if (key.Key == ConsoleKey.S)
    {
        row++;
    }
    if (key.Key == ConsoleKey.A)
    {
        column--;
    }
    if (key.Key == ConsoleKey.D)
    {
        column++;
    }
    if (row > number.GetLength(0) - 1)
    {
        row = number.GetLength(0) - 1;
    }
    if (row < 0)
    {
        row = 0;
    }
    if (column > number.GetLength(1) - 1)
    {
        column = number.GetLength(1) - 1;
    }
    if (column < 0)
    {
        column = 0;
    }
    Console.Clear();
    if (number[row, column] == 2)
    {
        row = oldRow;
        column = oldColumn;
    }

    if (number[row, column] == 3)
    {
        score += 10;
        do
        {
            row3 = new Random().Next(0, number.GetLength(0));
            column3 = new Random().Next(0, number.GetLength(1));
        } while (number[row3,column3] == 2 || number[row3,column3] == 1);

        number[row3, column3] = 3;
    }

    number[row, column] = 1;
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            Console.Write(number[i, j] + " ");
        }
        Console.WriteLine();

    }
    Console.WriteLine("Score: " + score);
}


