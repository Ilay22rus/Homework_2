Console.WriteLine("Ввести первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Ввести второе число: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"Максимальное число {numberA} минимальное число {numberB}");
}
else
{
    Console.WriteLine($"Максимальное число {numberB} минимальное число {numberA}");
}