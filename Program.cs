string[] SelectArray(string[] array, int size)
{
    int len = array.Length;
    string[] resultArray = new string[len];
    int index = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= size)
        {
            resultArray[index] = array[i];
            index++;
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}


string[] array1 = { "hello", "2", ":-)" };
Console.Write("array1: ");
PrintArray(array1);
Console.WriteLine();
string[] array2 = SelectArray(array1, 3);
Console.Write("array2: ");
PrintArray(array2);
