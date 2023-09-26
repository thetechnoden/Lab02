class Address
{
    public string Index { get; }
    public string Country { get; }
    public string City { get; }
    public string Street { get; }
    public string House { get; }
    public string Apartment { get; }

    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
        Apartment = apartment;
    }

    public void Display()
    {
        Console.WriteLine("Поштова адреса:");
        Console.WriteLine($"Індекс: {Index}");
        Console.WriteLine($"Країна: {Country}");
        Console.WriteLine($"Місто: {City}");
        Console.WriteLine($"Вулиця: {Street}");
        Console.WriteLine($"Будинок: {House}");
        Console.WriteLine($"Квартира: {Apartment}");
    }
}
