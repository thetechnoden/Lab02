class User
{
    public string Login { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public int Age { get; }
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
