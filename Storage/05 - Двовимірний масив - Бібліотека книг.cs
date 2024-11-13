// Ініціалізація двовимірного масиву книг
string[,] libraryBooks =
{
    { "Green Book 1", "Green Book 2", "Green Book 3" },
    { "Blue Book 1", "Blue Book 2", "Blue Book 3" },
    { "Orange Book 1", "Orange Book 2", "Orange Book 3" },
};

// Виведення всіх книг у бібліотеці
Console.WriteLine("Library Books:");
for (int i = 0; i < libraryBooks.GetLength(0); i++)
{
    for (int j = 0; j < libraryBooks.GetLength(1); j++)
    {
        Console.WriteLine($" - {libraryBooks[i, j]}");
    }
}