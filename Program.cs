string[] workArray = new string[5] {"123", "23", "hello", "world", "res"};

int CountStringSymbols(string[] workArray)
{
    int counter = 0;
    for (int i = 0; i < workArray.Length; i++)
    {
        if (workArray[i].Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] GenerateNewArray(string[] workArray)
{
    int resultArrayLength = CountStringSymbols(workArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] resultArray = GenerateNewArray(workArray);
PrintArray(workArray);
PrintArray(resultArray);