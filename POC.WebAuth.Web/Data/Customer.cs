using System;

namespace POC.WebAuth.Web.Data;

public class Customer
{
    public Customer(Guid id, string name, string email, DateTime birthDate)
    {
        Id = id;
        Name = name;
        Email = email;
        BirthDate = birthDate;
    }

    public Guid Id { get; private set; }

    // Empty constructor for EF
    protected Customer() { }

    public string Name { get; private set; }

    public string Email { get; private set; }

    public DateTime BirthDate { get; private set; }
}