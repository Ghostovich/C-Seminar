
 Console.Write("Введите число:");
int a = int.Parse(Console.ReadLine());


if (a==1) {
    Console.Write("x-положительное, у - положительное");
}
if (a==2) {
    Console.Write("x - отрицательное, у - положительное");
}if (a==3) {
    Console.Write("x-отрицательное, у - отрицательное");
}if (a==4) {
    Console.Write("x-положительное, у - отрицательное");
}if (a==0) {
    Console.Write("x=0, у=0");
}

   else if(a>4)
   {Console.Write("Введено некорректное значение");}