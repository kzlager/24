// Задача 24

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int n = 1; n <= number; n++)
{
    Console.Write($"{n * n * n} ");
}

//while ()
