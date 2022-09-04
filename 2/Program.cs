Console.Write("Введите числа (предлагаемый квадрат числа и само число):");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int z = y*y;
if (x==z) {
    Console.Write("1 число является квадратом второго");
}

else {
    Console.Write("1 число не является квадратом второго");
}