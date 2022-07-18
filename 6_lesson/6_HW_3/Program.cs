// Задача 3: Напишите программу, которая будет создавать копию заданного 
// двумерного массива с помощью поэлементного копирования.

void Print(int[,] arr)
{
    int RowSize = arr.GetLength(0);
    int ColumnSize = arr.GetLength(1);

    for (int i = 0; i < RowSize; i++)
    {
        for (int j = 0; j < ColumnSize; j++)
        {
        Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
    {
        arr[i, j] = new Random().Next(from, to);
    }
    
    }
    return arr;
}

int[,] CopyMass(int[,] arr)
{
    int RowSize = arr.GetLength(0);
    int ColumnSize = arr.GetLength(1);
    int[,] new_arr = new int[RowSize, ColumnSize];

    for (int i = 0; i < RowSize; i++)
    {
        for (int j = 0; j < ColumnSize; j++)
        {
            new_arr[i, j] = arr[i, j];
        }
    }

    return new_arr;
}

int[,] arr_1 = MassNums(5, 1, 2, 11);
Print(arr_1);
int[,] arr_1_new = CopyMass(arr_1);
Print(arr_1_new);

int[,] arr_2 = MassNums(8, 6, 20, 15);
Print(arr_2);
int[,] arr_2_new = CopyMass(arr_2);
Print(arr_2_new);

