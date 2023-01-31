// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
void Print1Array(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


void RowMinSumIndex(int[,] array)
{
    int minRow = 0;
    int index = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            index = i;
        }
        sumRow = 0;
    }
    Console.Write($"Номер строки с минимальной суммой элементов равен {index + 1}");
}
  



int row = GetUserData("Введите количество строк: ");
int col = GetUserData("Введите количество столбцов: ");
int[,] arr = get2DoubleArray(row, col, 0, 20);
PrintArray(arr);
RowMinSumIndex(arr);
