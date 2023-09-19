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