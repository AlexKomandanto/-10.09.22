string[] fArray = new string[11] {"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};
string[] sArray = new string[fArray.Length];
void FinishArray(string[] fArray, string[] sArray)
{
    int j = 0;
    for (int i = 0; i < fArray.Length; i++)
    {
    if(fArray[i].Length <= 3)
        {
        sArray[j] = fArray[i];
        j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
FinishArray(fArray, sArray);
PrintArray(sArray);