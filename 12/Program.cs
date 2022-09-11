int GetSum (int a)
{
int number = Math.Abs(a);
char[] arr = number.ToString().ToCharArray();
int sum = arr.Length;
return sum;
}

Console.Write("Введите число:");

try {
int a = int.Parse(Console.ReadLine());


int sum = GetSum(a);
Console.Write(sum);
}

catch (Exception ex){
Console.Write($"Неверный формат. Ошибка: {ex.Message}");  
}

