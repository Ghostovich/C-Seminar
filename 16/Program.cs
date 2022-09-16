int[] array = {1,2,3,4,5};


int[] PrintArrayToConsole (int[] array)
{
   int l = array.Length;
   int count1 = array[0]*array[l-1];
   int count2 =array[1]*array[l-2];
   int count3 = array[2];
       
   int[] arr = new int[] {count1, count2, count3};
   return arr;
  }
           

int[] print = PrintArrayToConsole(array);
Console.WriteLine (print);

//не решено