﻿class Address
{
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }

    public Address()
    {
        Index = "";
        Country = "";
        City = "";
        Street = "";
        House = "";
        Apartment = "";
    }
}