double GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}

void PrintInersection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"Пересечение в точке: ({x}; {y})");
    }

}

double b1 = GetIncomingData("Введите b1: ");
double k1 = GetIncomingData("Введите k1: ");
double b2 = GetIncomingData("Введите b2: ");
double k2 = GetIncomingData("Введите k2: ");
PrintInersection(b1, k1, b2, k2);
