int[,] GetArray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
}

int[,] GetSum(int[,] arr, int n, int m)
{
    int[,] arrN = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arrN[j, i] = arr[i, j];
        }
    }
    return arrN;
}

Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] arr = GetArray(n, m);
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

try
{
int[,] arrN = GetSum(arr, n, m);
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(arrN[i, j] + " ");
    }
    Console.WriteLine();
}
}

catch
{
    Console.WriteLine("Введите одинаковое количество строк и столбцов!");
}

