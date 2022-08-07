// Напишите программу, которая на вход принимает 3 числа, и выдает максимальное из этих чисел.

Console.Write("Введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

int max = FirstNumber;

if (max < SecondNumber) max = SecondNumber;
if (max < ThirdNumber) max = ThirdNumber;
 
Console.WriteLine(max + " является максимальным числом "); 