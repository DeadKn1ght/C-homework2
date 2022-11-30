// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.WriteLine("Input three-digit number :");
int number = int.Parse(Console.ReadLine());
if ((99 < number) && (number < 1000))
    Console.WriteLine("Second digit is :" + (number / 10) % 10);
else
    Console.WriteLine("You input incorect number");
