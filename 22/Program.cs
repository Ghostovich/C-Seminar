int[,] GetArray (int n, int m)
{
    int[,] array = new int[n, m];
    for (int i=0; i<n;i++)
    {
        for (int j=0; j<m; j++)
        {
           array [i,j] = new Random().Next(-10,10);
        }
    }
    return array;
}

int GetSum(int[,] arr, int n, int m)
{
    int sum = 0;
    for (int i=0; i<n;i++)
    {
        for (int j=0; j<m; j++)
        {
            if (i ==j)
            {
                sum = sum+arr [i,j];
            }
        }
    }   
    return sum;
}

Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine());

int[,] arr = GetArray(n,m);
for (int i=0; i<n;i++)
{
    for (int j=0; j<m; j++)
    {
        Console.Write(arr [i,j]+" ");
    }
    Console.WriteLine();
}
int printSum = GetSum(arr,n, m);
Console.WriteLine(printSum);