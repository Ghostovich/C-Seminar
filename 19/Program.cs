int n = 0;
int m = 0;

// Console.WriteLine("Введите количество столбцов:");
// n = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество строк:");
// m = int.Parse(Console.ReadLine());

// либо (заменяет try catch)

Console.WriteLine("Введите количество строк:");
bool parseNIsOk = int.TryParse(Console.ReadLine(), out int numberN);
if (!parseNIsOk)
{
    Console.WriteLine("Введено значение некорректного формата");
    return;
}
else
{
    n = numberN;
}

Console.WriteLine("Введите количество столбцов:");
bool parseMIsOk = int.TryParse(Console.ReadLine(), out int numberM);
if (!parseMIsOk)
{
    Console.WriteLine("Введено значение некорректного формата");
    return;
}
else
{
    m = numberM;
}

int[,] array = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(array[i, j]);
    }
    Console.WriteLine();
}