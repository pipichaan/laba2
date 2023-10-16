Console.WriteLine("Введите номер месяца");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 12 || x <= 2)
{
    Console.WriteLine("Зима");
}
else if (x >= 3 && x <= 5)
{
    Console.WriteLine("Весна");
}
else if (x >= 6 && x <= 8)
{
    Console.WriteLine("Лето");
}
else if (x >= 9 && x <= 11)
{
    Console.WriteLine("Осень");
}


