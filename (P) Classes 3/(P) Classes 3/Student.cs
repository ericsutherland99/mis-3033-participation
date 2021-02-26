using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes_3
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Major = string.Empty;
            GPA = 0;
            Address = new Address();

        }

        public Student(string firstname, string lastname, string major, double gpa)
        {
            Address = new Address();
            FirstName = firstname;
            LastName = lastname;
            GPA = gpa;
            Major = major;

        }

        public string CalculateDistinction()
        {
            string distinction;
            if (GPA >= 3.80)
            {
                distinction = "cum laude";
            }
            else if (GPA >= 3.60)
            {
                distinction = "magna cum laude";
            }
            else if (GPA >= 3.40)
            {
                distinction = "summa cum laude";
            }
            else
            {
                distinction = "No distinction";
            }
            return distinction;
        }

        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            Address = new Address(streetNumber, streetName, state, city, zipcode);
            Address.StreetNumber = streetNumber;
            Address.StreeName = streetName;
            Address.City = city;
            Address.State = state;
            Address.Zipcode = zipcode;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Major}, {CalculateDistinction()}";
        }
    }
}
