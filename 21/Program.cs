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
    for (int i=0; i<n;i++)
    {
        for (int j=0; j<m; j++)
        {
            if (i%2==0 && j%2 ==0)
            {
                 array [i,j]= array [i,j]* array [i,j];
            }
        }
    }   
    return array;
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