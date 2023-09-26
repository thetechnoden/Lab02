class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу Converter
        Converter converter = new Converter(28.5, 33.0, 7.0);
        double uahAmount = 1000;

        double usdAmount = converter.ConvertToUSD(uahAmount);
        Console.WriteLine($"Сума в USD: {usdAmount}");

        double eurAmount = converter.ConvertToEUR(uahAmount);
        Console.WriteLine($"Сума в EUR: {eurAmount}");

        double plnAmount = converter.ConvertToPLN(uahAmount);
        Console.WriteLine($"Сума в PLN: {plnAmount}");

        double convertedUAH = converter.ConvertFromUSD(50);
        Console.WriteLine($"Сума в UAH з USD: {convertedUAH}");
    }
}