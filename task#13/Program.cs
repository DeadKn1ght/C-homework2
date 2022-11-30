// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine("Input number :");
int number = int.Parse(Console.ReadLine());

if (number < 100)
    Console.WriteLine("This numer have no third digit");
if ((number>99)&&(number<1000))
    Console.WriteLine("Third digit of number is :" +number%10);
    else
        while(number>1000)
        {
            number = number /10;
        }
        Console.WriteLine("Third digit of number is :" +number%10);
