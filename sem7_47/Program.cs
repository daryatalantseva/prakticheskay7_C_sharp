// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк в массиве");
int m  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве");
int n  = Convert.ToInt32(Console.ReadLine());
double[,] myArr = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       myArr[i, j] = new Random().Next(10,100) + new Random().NextDouble();
       Console.Write("{0}\t", Math.Round(myArr[i, j], 2));
    }
    Console.WriteLine();
}
