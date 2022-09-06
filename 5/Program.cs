void CompareDigits ()
{
int x = new Random().Next(10,100);
int x1 = x/10;
int x2 =x%10;
Console.WriteLine(x);
if (x1>x2) {
    Console.Write("Первое число больше");
}

else 
if (x2>x1) {
    Console.Write("Второе число больше");
}
else  {
    Console.Write("Это паллиндром!");
}

}

CompareDigits();