int[] GetArray ()
{
    int size = new Random().Next(4,10);
    int[] array = new int[size];
    for (int i = 0; i<size; i++)
    {
        array[i] =  new Random().Next(-10,10);
    }
    return array;
}

int[] reverse(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i<array.Length; i++)
    {
        newArray[i] = array[array.Length-i-1];
    }
    return newArray;
}

int[] arr = GetArray();
Console.WriteLine(string.Join(", ", arr));
int[] newArr = reverse(arr);
Console.WriteLine(string.Join(", ", newArr));