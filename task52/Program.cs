// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}   ");
            Console.WriteLine();
    }         
}
void FillArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10);
}
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
FillArr(array);
PrintArr(array);
Result(array);
void Result (int [,] matrix)
{   Console.Write("Среднее арифметическое каждого столбца:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {      double res = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            res = res + matrix[j,i];
            double finish = Math.Round (res/matrix.GetLength(1),1);
            Console.Write($"  {finish}  ");
    } 
}

