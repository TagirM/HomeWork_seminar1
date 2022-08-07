// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int n = 1;

System.Console.WriteLine("Четные числа от 1 до заданного: ");

while (n <= Number)
{
    if (n % 2 == 0) System.Console.WriteLine(n);
    n++;
}

