void CompareDigits ()
{
int x = new Random().Next(100,999);
int x1 = x/100;
int x2= x/10;
int x3 =x%10;
Console.WriteLine($"{x}->{x1}{x3}");
}

CompareDigits();