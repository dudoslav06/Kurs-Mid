using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;

        private string contactNumber;

        public static int Count = 0;

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (value.Length < 9 )
                {
                    Console.WriteLine("invalid contact number");
                } 
                else
                {
                    contactNumber = value;
                }
            }
        }


        public Person(string firstName, string lastName)
        {
            Console.WriteLine("Constr1");
            FirstName = firstName;
            LastName = lastName;
            Count++;
        }
        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName,lastName)
        {
            Console.WriteLine("constr2");
            SetDateOfBirth(dateOfBirth);
        }

        public void SetDateOfBirth(DateTime date)
        {
            if (date > DateTime.Now)
            {
                Console.WriteLine("invalid date");
            }
            else
            {
                dateOfBirth = date;
            }
        }

        public DateTime GetDateOfBirth() => dateOfBirth;

        //public DateTime GetDateOfBirth() -> powyzszy kod to to samo co ponizej
        //{
        //    return dateOfBirth;
        //}

        public void SayHi()
        {
        Console.WriteLine($"Hi, i`m {FirstName}, {GetDateOfBirth()}");
        }
    }
}
