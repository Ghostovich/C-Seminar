int GetSum (int number)
{
  int sum = 0;
  if (number>0){
  for (int i = 1; i<=number; i++)
  {
    sum = sum + i;
  }
  }
    if (number<0){
  for (int i = 1; i>=number; i--)
  {
    sum += i;
  }
  }
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

