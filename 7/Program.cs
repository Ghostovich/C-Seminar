 Console.Write("Введите числа:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int c = a*a;
int d = b*b;
if (c==b | d==a) {
    Console.Write("Да");
}

else  {
    Console.Write($"Нет");
}

