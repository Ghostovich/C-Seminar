int GetSide () base (side1, side2, side3)
{
    int side1 = new Random().Next(1,10);
    int side2 = new Random().Next(1,10);
    int side3 = new Random().Next(1,10);
    return new (side1, side2, side3);
}

// int[] reverse(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for (int i = 0; i<array.Length; i++)
//     {
//         newArray[i] = array[array.Length-i-1];
//     }
//     return newArray;
// }

int side = GetSide();
Console.WriteLine(string.Join(", ", side));
// int[] newArr = reverse(arr);
// Console.WriteLine(string.Join(", ", newArr));