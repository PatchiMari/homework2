// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

int [,] array = new int[3,5];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,11);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] +" ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

CreateArray();
PrintArray();

void ChangeString()
{
    int b= array.GetLength(0)-1;
    int x= 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            x = array[0,j];  
            array[0,j]= array[b,j];
            array[b,j]=x;
        }
    
}
ChangeString();
PrintArray();