string[] FilterShortStrings(string[] array)
{
    int shortStringsCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            shortStringsCount++;
        }
    }

    string[] shortStrings = new string[shortStringsCount];
    int currentIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            shortStrings[currentIndex] = array[i];
            currentIndex++;
        }
    }

    return shortStrings;
}


Console.WriteLine("Enter lines separated by comma:");
string[] originalArray = Console.ReadLine().Split(',');

string[] shortStrings = FilterShortStrings(originalArray);

Console.WriteLine("Initial array:");
Console.WriteLine(string.Join(", ", originalArray));

Console.WriteLine("Array of short strings:");
Console.WriteLine(string.Join(", ", shortStrings));
