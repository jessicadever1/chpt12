using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        public string CompanyName { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> CurrentEmployees { get; set; }
        public Company(string nameOfCompany, DateTime dateOfEstablishment)
        {
            CompanyName = nameOfCompany;
            CreatedOn = dateOfEstablishment;
        }
    }
}