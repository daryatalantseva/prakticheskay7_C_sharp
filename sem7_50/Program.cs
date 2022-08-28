/* Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

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
Console.WriteLine("Введите искомое число");
int x  = Convert.ToInt32(Console.ReadLine());
int a = -1;
int b = -1; 
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       if (myArr[i, j] == x)
       {
         a = i;
         b = j;
       }
    }
    
}

if ((a == -1) && (b == -1))

    Console.Write("Элемент не найден ");

else

    Console.Write("Элемент находится в строке номер " + a + " в столбце номер " + b);

