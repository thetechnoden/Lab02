enum Position
{
    Manager,
    Developer,
    Coder
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

    public double CalculateSalary(Position position, int experience)
    {
        double baseSalary = 0;
        
        switch (position)
        {
            case Position.Manager:
                baseSalary = 30000;
                break;
            case Position.Developer:
                baseSalary = 40000;
                break;
            case Position.Coder:
                baseSalary = 35000;
                break;              
        }

        double experienceBonus = 0;
 
        if (experience >= 5)
        {
            experienceBonus = 5000;
        }

        double salary = baseSalary + experienceBonus;
        double tax = 0.15 * salary; 
        return salary - tax;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {lastName}");
        Console.WriteLine($"Surname: {firstName}");
    }
}
