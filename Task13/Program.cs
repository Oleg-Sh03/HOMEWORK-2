// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 || number <= -100)
{
    while (number >= 1000 || number <= -1000)
    {
        number = number / 10;
    }
int num = number % 10;
Console.WriteLine(num); 
}
else Console.WriteLine("Третьей цифры нет");