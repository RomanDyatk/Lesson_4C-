int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 1000);
        }

    }

    return matrix;
}

int[,] matrix = CreateMatrix(3, 4);

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }

        Console.WriteLine();
    }
}

ShowMatrix(matrix);

foreach (int i in matrix)
{
    if (isInteresting(i) == true)
    {
        Console.WriteLine(i);
    }
}

bool isInteresting(int value)
{
    int SumOfDigits = GetSumOfDigits(value);
    if (SumOfDigits % 2 == 0)
    {
        return true;
    }
    
    return false;
    
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}
