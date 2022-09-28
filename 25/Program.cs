int[,] GetArray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int[] GetSum(int[,] arr, int n, int m)
{
    int[] arrN = new int[10] {0,0,0,0,0,0,0,0,0,0,};
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (arr[i, j] == 0) { arrN[0] += 1; }
            if (arr[i, j] == 1) { arrN[1] += 1; }
            if (arr[i, j] == 2) { arrN[2] += 1; }
            if (arr[i, j] == 3) { arrN[3] += 1; }
            if (arr[i, j] == 4) { arrN[4] += 1; }
            if (arr[i, j] == 5) { arrN[5] += 1; }
            if (arr[i, j] == 6) { arrN[6] += 1; }
            if (arr[i, j] == 7) { arrN[7] += 1; }
            if (arr[i, j] == 8) { arrN[8] += 1; }
            if (arr[i, j] == 9) { arrN[9] += 1; }

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


int[] arrN = GetSum(arr, n, m);
for (int i = 0; i < arrN.Length; i++)
{
    Console.WriteLine($"{i} встречается {arrN[i]} раз");
}
Console.WriteLine();



