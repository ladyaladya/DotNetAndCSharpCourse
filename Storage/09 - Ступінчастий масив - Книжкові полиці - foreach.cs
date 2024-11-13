// Ініціалізація ступінчастого масиву книг
string[][] bookShelves =
[
    [ "Green Book 1", "Green Book 2", "Green Book 3" ],
    [ "Blue Book 1", "Blue Book 2" ],
    [ "Orange Book 1" ]
];

// Виведення всіх книг на полицях
Console.WriteLine("Book Shelves:");
int row = 1;
foreach (var shelf in bookShelves)
{
    Console.WriteLine($"Row {row++}:");
    foreach (var book in shelf)
    {
        Console.WriteLine($" - {book}");
    }
}
