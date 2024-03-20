using System;

namespace ReferenceTypes;

public class Program
{
    static void Main(string[] args)
    {
        //int sayi1 = 10;
        //int sayi2 = 20;
        //sayi1 = sayi2;

        //Console.WriteLine(sayi1);

        //int[] sayilar1 = new int[] { 1, 2, 3 };
        //int[] sayilar2 = new int[] { 10, 20, 30 };

        //sayilar1 = sayilar2;
        //sayilar2[0] = 1000;
        //Console.WriteLine("Sayılar1[0] : "+ sayilar1[0]);


        Person person1 = new Person();
        Person person2 = new Person();

        person1.FirstName = "Engin";
        person2 = person1;

        person1.FirstName = "Kerem";
        Console.WriteLine(person2.FirstName);


        Costumer costumer = new Costumer();
        costumer.FirstName = "Burak";
        Employee employee = new Employee();
        employee.FirstName = "Mustafa";

        Person person3 = costumer;
        Console.WriteLine(person3.FirstName);

        PersonManager personManager = new PersonManager();
        personManager.Add(person2);
        personManager.Add(costumer);
        personManager.Add(employee);

    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
    class Costumer : Person
    {
        public string CreditCardnumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployyeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName + " added");
        }
    }


}