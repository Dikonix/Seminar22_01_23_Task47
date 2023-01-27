void CreateRandomArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void ShowArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int numberOfLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int numberOfColumns = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[numberOfLines, numberOfColumns];
CreateRandomArray(array);
ShowArray(array);