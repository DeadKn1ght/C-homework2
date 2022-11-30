// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Input number (1-7) :");
int number = int.Parse(Console.ReadLine());

if (number > 7)
    Console.WriteLine("You input incorect number");
else
    if ((number >= 1) && (number <= 5))
        Console.WriteLine("No! Its work day");
        else
        Console.WriteLine("Yes!It's HOLIDAY");