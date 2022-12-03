// Задача 4
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
    Console.WriteLine($"max = {a}");
else if (a < b && c < b)
    Console.WriteLine($"max = {b}");
else if (a < c && b < c)
    Console.WriteLine($"max = {c}");