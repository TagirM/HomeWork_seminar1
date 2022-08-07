// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка).

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 2 == 0) Console.WriteLine(Number + " является четным числом ");
else Console.WriteLine(Number + " является нечетным числом ");

