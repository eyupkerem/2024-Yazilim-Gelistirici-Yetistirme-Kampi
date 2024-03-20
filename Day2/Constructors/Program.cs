using System;

namespace Constructors;

class Program
{
    static void Main(string[] args)
    {
        Costumer costumer = new Costumer(); 
    }
}

class Costumer
{
    public Costumer()
    {
        
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}