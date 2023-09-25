class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу Address
        Address address = new Address("12345", "Україна", "Київ", "Вулиця Хрещатик", "1", "10");
        address.Display();

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
        Employee employee = new Employee("Петров", "Іван");
        employee.DisplayInfo();
        double salary = employee.CalculateSalary(Position.Менеджер, 6); 
        Console.WriteLine($"Зарплата: {salary} грн");

        // Приклад використання класу User
        User user = new User("user123", "Іван", "Петров", 30);
        user.DisplayInfo();

        Console.ReadLine();
    }
}
