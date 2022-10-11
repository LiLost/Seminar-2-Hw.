// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

if (number == 6 || number == 7)
{
    Console.WriteLine($"День {number} выходной");
}
else
{
    Console.WriteLine($"День {number} не выходной");
}
