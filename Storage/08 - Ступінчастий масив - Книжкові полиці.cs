// Ініціалізація та отримання елементів ступінчастого масиву
string[][] bookShelves =
{
    new string[] { "Green Book 1", "Green Book 2", "Green Book 3" },
    new string[] { "Blue Book 1", "Blue Book 2" },
    new string[] { "Orange Book 1" }
};

Console.WriteLine("Book Shelves:");
for (int i = 0; i < bookShelves.Length; i++)
{
    Console.WriteLine($"Row {i + 1}:");
    for (int j = 0; j < bookShelves[i].Length; j++)
    {
        Console.WriteLine($" - {bookShelves[i][j]}");
    }
}