//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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


int[,] RowMaxMin(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = i; j < array.GetLength(1); j++)
        {
            for(int num = 0; num < array.GetLength(1) - 1; num++)
            {
                if (array[i,num] < array[i,num+1])
                {
                    int temp = array[i,num+1];
                    array[i,num+1] = array[i,num];
                    array[i,num] = temp;
                }
            }
        }
    } 
    return array;       
}
        



int row = GetUserData("Введите количество строк: ");
int col = GetUserData("Введите количество столбцов: ");
int[,] arr = get2DoubleArray(row, col, 0, 20);
PrintArray(arr);
int[,] newarr = RowMaxMin(arr);
PrintArray(newarr);
