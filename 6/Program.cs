 Console.Write("Введите числа:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int c = a%b;
if (c==0) {
    Console.Write("Число кратно");
}

else  {
    Console.Write($"Число не кратно, остаток {c}");
}

