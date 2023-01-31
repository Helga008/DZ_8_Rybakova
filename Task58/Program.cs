// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int GetUserData(string message)
{
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;

}

int[,] get2DoubleArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    
    for(int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start, finish+1);
        }
    }
    return array;
}


void printInColor(string message)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(message);
    Console.ResetColor();
}

void PrintArray(int[,] array)
{
    Console.Write(" \t");
    for(int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
    Console.WriteLine();
    }
}
int row1 = GetUserData("Введите количество строк первой матрицы: ");
int col1 = GetUserData("Введите количество столбцов первой матрицы: ");
int row2 = GetUserData("Введите количество строк первой матрицы: ");
int col2 = GetUserData("Введите количество столбцов первой матрицы: ");

int[,] arr1 = get2DoubleArray(row1, col1, 0, 20);
int[,] arr2 = get2DoubleArray(row2, col2, 0, 20);
PrintArray(arr1);
PrintArray(arr2);



void multiplicationMartix(int[,] arr1, int[,] arr2)
{

    if (arr1.GetLength(0) != arr2.GetLength(1))
    {
        Console.WriteLine("Умножение матриц невозможно");
    }
    int[,] multiarr = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            multiarr[i, j] = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                multiarr[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    PrintArray(multiarr);
}    

multiplicationMartix(arr1, arr2);