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

