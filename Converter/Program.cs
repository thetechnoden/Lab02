class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter(28.5, 33.0, 7.0);
        double uahAmount = 1000;

        double usdAmount = converter.ConvertToUSD(uahAmount);
        Console.WriteLine($"Total in USD: {usdAmount}");

        double eurAmount = converter.ConvertToEUR(uahAmount);
        Console.WriteLine($"Total in EUR: {eurAmount}");

        double plnAmount = converter.ConvertToPLN(uahAmount);
        Console.WriteLine($"Total in PLN: {plnAmount}");

        double convertedUAH = converter.ConvertFromUSD(50);
        Console.WriteLine($"Total in UAH from USD: {convertedUAH}");

        Console.ReadLine();
    }
}