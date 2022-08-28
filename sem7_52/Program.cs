/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


Console.WriteLine("Введите количество строк в массиве");
int m  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве");
int n  = Convert.ToInt32(Console.ReadLine());
int[,] myArr = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       myArr[i, j] = new Random().Next(1,100);
       Console.Write("{0}\t", myArr[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine("Средние значения");
double[] x  = new double[n];

double sred_arifm = 0;
for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
       sum = sum + myArr[i,j];
    }
    sred_arifm = sum / m;
    x[j] = sred_arifm;
}
for (int i = 0; i < n; i++)
{
    Console.Write("{0}\t", x[i]);
}