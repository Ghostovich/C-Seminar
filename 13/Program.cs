int GetSum (int a)
{
    int sum = 1;
    if (a>0)
    {
       for (int i=1; i<=a; i++){
        sum = i*sum;
       } 
    }

    if (a<=0){
      sum = 0;
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

