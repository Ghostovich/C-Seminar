int[] GetArray ()
{
    int[] array = new int[8];

       for (int i=0; i<array.Length; i++)
       {
        array[i] = new Random().Next(0,2);
       } 

return array;
}

void PrintArrayToConsole (int[] array)
{
          for (int i=0; i<=array.Length; i++)
       {
        Console.WriteLine(array[i]);
       } 
}

int[] array = GetArray();
PrintArrayToConsole(array);

