﻿class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }

    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        this.index = index;
        this.country = country;
        this.city = city;
        this.street = street;
        this.house = house;
        this.apartment = apartment;
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