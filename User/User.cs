class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private DateTime registrationDate;

    public string Login
    {
        get { return login; }
        set { login = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public DateTime RegistrationDate
    {
        get { return registrationDate; }
    }

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        Age = age;
        registrationDate = DateTime.Now;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Login: {Login}");
        Console.WriteLine($"Name: {FirstName}");
        Console.WriteLine($"Surname: {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Registration date: {RegistrationDate}");
    }
}
