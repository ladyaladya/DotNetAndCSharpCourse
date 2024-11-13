// Маніпуляції з масивом з використанням циклу foreach
int[] numbers = { 1, 2, 34, 54, 7, 0, -24, 4, 5, 7, 8, 10 };
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine("Sum using foreach loop: " + sum);