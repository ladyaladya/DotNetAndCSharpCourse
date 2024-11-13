// Ініціалізація тривимірного масиву книг
string[,,] librarySections =
{
    {
        { "Green Book 1", "Green Book 2", "Green Book 3" }, // Секція 1, Полиця 1
        { "Green Book 4", "Green Book 5", "Green Book 6" }  // Секція 1, Полиця 2
    },
    {
        { "Blue Book 1", "Blue Book 2", "Blue Book 3" },    // Секція 2, Полиця 1
        { "Blue Book 4", "Blue Book 5", "Blue Book 6" }     // Секція 2, Полиця 2
    },
    {
        { "Orange Book 1", "Orange Book 2", "Orange Book 3" }, // Секція 3, Полиця 1
        { "Orange Book 4", "Orange Book 5", "Orange Book 6" }  // Секція 3, Полиця 2
    }
};

// Виведення всіх книг у бібліотеці
Console.WriteLine("Library Books by Section and Shelf:");
for (int section = 0; section < librarySections.GetLength(0); section++)
{
    Console.WriteLine($"Section {section + 1}:");

    for (int shelf = 0; shelf < librarySections.GetLength(1); shelf++)
    {
        Console.WriteLine($" Shelf {shelf + 1}:");

        for (int book = 0; book < librarySections.GetLength(2); book++)
        {
            Console.WriteLine($"  - {librarySections[section, shelf, book]}");
        }
    }
}
