string[,] people = {
    { "Олена", "25" },
    { "Надія", "30" },
    { "Володимир", "45" }
};

int totalAge = 0;
int peopleCount = people.GetLength(0);
for (int i = 0; i < peopleCount; i++)
{
    totalAge += int.Parse(people[i, 1]);
}

Console.WriteLine($"Average age: {totalAge / peopleCount}");