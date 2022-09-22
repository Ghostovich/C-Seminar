int[] GetArray ()
{
    int[] array = new int[123];

       for (int i=0; i<array.Length; i++)
       {
        array[i] = new Random().Next(0,124);
       } 

return array;
}

int PrintArrayToConsole (int[] array)
{
   int count = 0;
   for (int i=0; i<array.Length; i++)
       {
        if (array[i]>9 && array[i]<100)
         {
            count+=1;
         }
       } 
       return count;
  }
           

int[] array = GetArray();
int print = PrintArrayToConsole(array);
Console.WriteLine (print);