int Long (int x1, int x2, int y1, int y2)
{
int d = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
int k = Convert.ToInt32(Math.Sqrt(d));
return k;
}
 Console.Write("Введите координаты Х и У точки 1:");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты Х и У точки 2:");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());

int res = Long(x1, x2, y1, y2);
Console.WriteLine(res);

