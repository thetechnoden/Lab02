class Program
{
    static void Main(string[] args)
    {
        User user = new User("user123", "Nubas", "Nubikov", 12);
        user.DisplayInfo();

        Console.ReadLine();
    }
}