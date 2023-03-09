// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateMatrix(int m, int n, int leftRange, int rightRange)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Position(int[,] matrix, int[] pos)
{

    if (pos[0] >= 0 && pos[1] >= 0 && pos[0] <= matrix.GetLength(0) && pos[1] <= matrix.GetLength(1))
    {
        System.Console.WriteLine($"{matrix[pos[0] , pos[1] ]}");
    }
    else
    {
        System.Console.WriteLine($"{pos[0]} {pos[1]} - wrong number");
    }
}

int[] InputArray(string text)
{
    System.Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}

int[,] myMatrix = CreateMatrix(5, 5, 0, 99);
PrintArray(myMatrix);
int[] myArray = InputArray("Input position");
Position(myMatrix, myArray);
