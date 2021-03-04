using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateFounded = new DateTime(1515, 12, 25);
            Company hogwarts = new Company("Hogwarts", dateFounded);

            Employee harry = new Employee("Harry", "Potter", "Seeker", new DateTime(2000, 9, 6));
            Employee ron = new Employee("Ron", "Weasley", "Head Boy", new DateTime(2000, 9, 6));
            Employee hermione = new Employee("Hermione", "Granger", "Head Girl", new DateTime(2000, 9, 6));

            hogwarts.CurrentEmployees = new List<Employee>()
                {
                    harry, ron, hermione
                };

            foreach (Employee person in hogwarts.CurrentEmployees)
                Console.WriteLine($"{person.FirstName} {person.LastName} works for {hogwarts.CompanyName} as a {person.Title} since {person.StartDate.ToShortDateString()} ");
        }
    }
}