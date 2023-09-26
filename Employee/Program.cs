class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу Employee
        Employee employee = new Employee("Петров", "Іван");
        employee.DisplayInfo();
        double salary = employee.CalculateSalary(Position.Менеджер, 6);
        Console.WriteLine($"Зарплата: {salary} грн");
    }
}