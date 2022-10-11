// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);
int a = (number / 10);
int a2 = (number / 10) % 10;

Console.WriteLine($"Вторая цифра этого трехзначного числа {a2}");
