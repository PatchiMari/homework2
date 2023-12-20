// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.


Console.Write($"Введите количество строк в массиве: ");
    int stroka=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    Console.Write($"Введите количество столбцов в массиве: ");
    int stolb=Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[stroka,stolb];

void mas(int stroka, int stolb)
{
int i,j;
    Random rand = new Random();
    for (i = 0; i < stroka; i++)
    {
        for (j = 0; j < stolb; j++)
        {
            randomArray[i,j] = rand.Next(0,11);
        }
    }
}

void printString(int[,] array)
{
    int i,j;
    for (i = 0; i < array.GetLength(0); i++)
        {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
            {
            Console.Write($"{array[i,j]} ");
            }
        Console.WriteLine();
        }
}

mas(stroka,stolb);
printString(randomArray);

// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
        {
        sum += array[i,j];
        }
    return sum;
}

int minSum = 0;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
    {
    if (sum > SumLine(randomArray, i))
        {
        sum = SumLine(randomArray, i);
        minSum = i+1;
        }
    }
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");

