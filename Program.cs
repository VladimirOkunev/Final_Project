// Написать программу, которая из имеющегося массива строк
// формирует массив строк, длина которых меньше или равна 3 символа

string[] StringParse(string[] stringArray)
{
    int n = 0;
    foreach (string word in stringArray) // define length (n) of new array
    {
        if (word.Length <= 3) n++;
    }
    string[] newArray = new string[n];
    n = 0;
    foreach (string word in stringArray)// fill in the new array by words with length less of equal 3 letters
    {
        if (word.Length <= 3)
        {
            newArray[n] = word;
            n++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

string [] arr = {"hello", "2", "world", ":-)"};
//string[] arr = { "Russian", "Denmark", "Kazan" };
//string[] arr = { "1234", "1567", "-2", "computer science" };
Console.Write("Original array: ");
PrintArray(arr);
arr = StringParse(arr);
Console.Write("New array: ");
PrintArray(arr);
