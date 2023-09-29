class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Селик", "Артем");
        employee.DisplayInfo();
        double salary = employee.CalculateSalary(Position.Manager, 8);
        Console.WriteLine($"Зарплата: {salary} грн");

        Console.ReadLine();
    }
}