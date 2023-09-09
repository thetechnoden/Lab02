using System;

class Address
{
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }
    
    public Address()
    {
        Index = "";
        Country = "";
        City = "";
        Street = "";
        House = "";
        Apartment = "";
    }
}


class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / usd;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / eur;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / pln;
    }

    public double ConvertFromUSD(double amountInUSD)
    {
        return amountInUSD * usd;
    }

    public double ConvertFromEUR(double amountInEUR)
    {
        return amountInEUR * eur;
    }

    public double ConvertFromPLN(double amountInPLN)
    {
        return amountInPLN * pln;
    }
}

class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public double CalculateSalary(string position, int experience)
    {
        double baseSalary = 0;
        
        switch (position)
        {
            case "Менеджер":
                baseSalary = 30000;
                break;
            case "Розробник":
                baseSalary = 40000;
                break;
        }

        double experienceBonus = 0;
        
        if (experience >= 5)
        {
            experienceBonus = 5000;
        }

        double salary = baseSalary + experienceBonus;
        double tax = 0.15 * salary; // 15% податок
        return salary - tax;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
    }
}

class User
{
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Логін: {Login}");
        Console.WriteLine($"Ім'я: {FirstName}");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Вік: {Age}");
        Console.WriteLine($"Дата реєстрації: {RegistrationDate}");
    }
}

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
