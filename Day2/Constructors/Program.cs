using System;

namespace Constructors;

class Program
{
    static void Main(string[] args)
    {
        Costumer costumer = new Costumer(1,"Ahmet","Gunay","Ankara"); 
    }
}

class Costumer
{
    public Costumer(int id,string firstName,string lastName,string city)
    {
        
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}