class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу Address
        Address address = new Address
        {
            Index = "12345",
            Country = "Україна",
            City = "Київ",
            Street = "Вулиця Лісова",
            House = "3",
            Apartment = "27"
        };

        Console.WriteLine("Поштова адреса:");
        Console.WriteLine($"Індекс: {address.Index}");
        Console.WriteLine($"Країна: {address.Country}");
        Console.WriteLine($"Місто: {address.City}");
        Console.WriteLine($"Вулиця: {address.Street}");
        Console.WriteLine($"Будинок: {address.House}");
        Console.WriteLine($"Квартира: {address.Apartment}");

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

        // Приклад використання класу Employee
        Employee employee = new Employee("Олегович", "Олег");
        employee.DisplayInfo();
        double salary = employee.CalculateSalary("Менеджер", 6);
        Console.WriteLine($"Зарплатня: {salary} грн");

        // Приклад використання класу User
        User user = new User("user123", "Олег", "Олегович", 30);
        user.DisplayInfo();

        Console.ReadLine();
    }
}
