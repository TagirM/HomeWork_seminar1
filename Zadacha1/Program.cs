// Напишите программу, которая на вход принимает 2 числа, и выдает, какое число большее, какое меньшее.

Console.Write("Введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber < SecondNumber)
{
    Console.WriteLine(FirstNumber + " является меньшим числом ");
    Console.Write(SecondNumber + " является большим числом ");
}
else
{
     Console.WriteLine(SecondNumber + " является меньшим числом "); 
     Console.Write(FirstNumber + " является большим числом ");
}


