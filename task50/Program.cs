// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// Пример
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ввод:
// 2 строка
// 1 столбец
// Вывод:
// 4
Console.Clear();
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10);
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}   ");
        Console.WriteLine();
    }
}
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, m];
FillArray(arr);
PrintArray(arr);
Console.WriteLine("Ввведите позицию интересующего вас элемента:  ");
int numbersY = Convert.ToInt32(Console.ReadLine());
int numbersX = Convert.ToInt32(Console.ReadLine());
ResultArray(arr);
void ResultArray(int[,] matrix)
{
    if (n > numbersY && m > numbersX )
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == numbersY && j == numbersX)
                    Console.WriteLine($"число = {matrix[i, j]}");
            }
        }
    }
    else
        Console.WriteLine("Такой позиции не существует");
}
