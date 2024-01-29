double number1, number2;

Console.WriteLine("Введіть перше число:");
while (!double.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Некоректний ввід. Будь ласка, введіть число знову:");
}

Console.WriteLine("Введіть друге число:");
while (!double.TryParse(Console.ReadLine(), out number2))
{
    Console.WriteLine("Некоректний ввід. Будь ласка, введіть число знову:");
}

double sum = number1 + number2;

Console.WriteLine($"Сума чисел {number1} і {number2} дорівнює: {sum}");

Console.ReadLine();