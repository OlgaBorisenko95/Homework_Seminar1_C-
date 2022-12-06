Console.Clear();

Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());

int max = a;

if (b >= max)

max = b;

{
    Console.WriteLine($"Наибольшее число {max}");
}



