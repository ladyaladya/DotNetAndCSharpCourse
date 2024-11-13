// Маніпуляції з масивом за допомогою циклу
int[] numbers = { 1, 2, 34, 54, 7, 0, -24, 4, 5, 7, 8, 10 };
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine("Sum using for loop: " + sum);