Console.WriteLine("Вводим первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Вводим второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Вводим третье число: ");
int numberC = int.Parse(Console.ReadLine());
if (numberA > numberB & numberA > numberC)
{
    Console.WriteLine($"Число {numberA} наибольшее число");
}
if (numberB > numberA & numberB > numberC)
{
    Console.WriteLine($"Число {numberB} наибольшее число");
}
if (numberC > numberA & numberC > numberB)
{
    Console.WriteLine($"Число {numberC} наибольшее число");
}

//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
