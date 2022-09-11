// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Enter the required number of digits: ");
int number = int.Parse(Console.ReadLine());
int result = 0; int count = 0;

int NumbersOfDigits(int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write("Enter a number: ");
        result = int.Parse(Console.ReadLine());
        if (result > 0) count++;
    }
    return count;
}

Console.WriteLine($"Number of positive digits entered = {NumbersOfDigits(number)}");