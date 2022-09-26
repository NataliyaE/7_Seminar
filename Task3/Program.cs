// задать двум массив. найти ср арифм в каждом столбце

int rows = new Random().Next(3, 7);
int columns = new Random().Next(3, 7);
int [,] array = new int [rows, columns];

CreateArray(array);
PrintArray(array);
Console.WriteLine();
FindAverageArithmetic(array);

void CreateArray(int[,] array)
{
    for (int  i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void FindAverageArithmetic(int[,] array)
{
    for (int  j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        int column = array.GetLength(0);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = (result + array[i, j]);
        }
        result = result / (column);
        Console.Write($"{result}; ");
    }
}

void PrintArray (int[,] array)
{
    for (int  i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

