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
            arrN[0, j] = arr[n - 1, j];
            arrN[n - 1, j] = arr[0, j];

        }
    }
    return arrN;
}

int[,] GetUmm(int[,] arr, int[,] arrN, int n, int m)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[n - 1, j] = arrN[n - 1, j];
            arr[0, j] = arrN[0, j];

        }
    }
    return arr;
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

int[,] arrN = GetSum(arr, n, m);

int[,] printUmm = GetUmm(arr, arrN, n, m);
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(printUmm[i, j] + " ");
    }
    Console.WriteLine();
}
