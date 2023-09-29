class Program
{
    static void Main(string[] args)
    {
        User user = new User("user123", "Нубас", "Нубіков", 12);
        user.DisplayInfo();

        Console.ReadLine();
    }
}