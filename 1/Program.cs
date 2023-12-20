// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.


int[,] CreateArray(int a, int b)
{
    int [,] array= new int[a,b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,11);
        }
    }
    return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] +" ");
        }
        System.Console.WriteLine();
    }
}

void Massive()
{
    Console.Write($"Введите количество строк в массиве: ");
    int stroka=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    Console.Write($"Введите количество столбцов в массиве: ");
    int stolb=Convert.ToInt32(Console.ReadLine());

    if(stroka > 0 && stolb > 0)
    {
       int[,]array= CreateArray(stroka,stolb);
       PrintArray(array);
       FindElArray(array);
    }
    else
    {
        System.Console.Write("Некорректный размер массива!");
    }
}
Massive();

void FindElArray(int [,]array)
{
    Console.Write($"Введите номер строки: ");
    int stroka2= Convert.ToInt32(Console.ReadLine())-1;
    Console.Write($"Введите номер столбца: ");
    int stolb2= Convert.ToInt32(Console.ReadLine())-1;
    if(stroka2 < array.GetLength(0) && stroka2>= 0 && stolb2 < array.GetLength(1) && stolb2 >=0)
    {
        System.Console.Write(array[stroka2,stolb2]);
    }
    else
    {
        System.Console.Write("Некорректная позиция элемента!");
    }
}