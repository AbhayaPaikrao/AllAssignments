using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
       
            public Person(string First_name, string Last_name, string email, DateTime dob)
            {
                this.First_name = First_name;
                this.Last_name = Last_name;
                this.Email = email;
                this.dateOfBirth = dob;
            }
            public string First_name { get; set; }
            public string Last_name { get; set; }
            public string Email { get; set; }
            public DateTime dateOfBirth { get; set; }

            // private readonly bool Adult ;
            // private readonly bool Birthday;

            // private readonly DateTime dateOfBirth;

            public bool Adult
            {
                get { return CalculateAdultStatus(); }
            }
            public bool IsTodayYourBirthDay
            {
                get { return birthDay(); }
            }
            private bool birthDay()
            {
                DateTime today = DateTime.Today;
                return (today.Month == dateOfBirth.Month && today.Day == dateOfBirth.Day);
            }
            private bool CalculateAdultStatus()
            {
                // Calculate adult status based on date of birth
                DateTime today = DateTime.Today;
                int age = today.Year - dateOfBirth.Year;
                if (today < dateOfBirth.AddYears(age))
                {
                    age--;
                }
                return age >= 18;
            }
    }
}
