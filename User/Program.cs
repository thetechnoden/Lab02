class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу User
        User user = new User("user123", "Іван", "Петров", 30);
        user.DisplayInfo();

        Console.ReadLine();
    }
}