﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Classes
{
    class Person
    {
        public string FirstName { get; set; }
        public string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime DateOfBirth { get; set; }

        public Vehicle Transport { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }

        public Person() { }

        public Person(string firstName, string lastName, DateTime dob, Vehicle transport)
        {
            firstName = firstName;
            lastName = lastName;
            DateOfBirth = dob;
            Transport = transport;

         }

    }
}
