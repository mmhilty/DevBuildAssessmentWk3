using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assessment3_1_MyPeeps
{
    class Person
    {

        public string firstname;
        public string lastname;
        public int age;
        public string email;
        public bool isadult = false;

        public Person(string firstname, string lastname, int age, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.email = email;
            if (age >= 18)
            {
                isadult = true;
            }
            
        }

        public static Person CreatePerson()
        {
            string inputfirst = StringGetter.Get("Enter the first name:");
            string inputlast = StringGetter.Get("Enter the last name:");
            int inputage;
            while (true)
            {
                if (int.TryParse(StringGetter.Get("Enter the age:"), out inputage))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid entry. Please enter a whole number");
                }
            }

            string inputemail;
            while (true)
            {
                string inputemailORIG = StringGetter.Get("Enter the email:");
                if (Regex.IsMatch(inputemailORIG, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
              
                {
                    inputemail = inputemailORIG;
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid email format.");
                }
            }

            return new Person(inputfirst, inputlast, inputage, inputemail);
        }

        /*        
         1.First Name2.Last Name3.Age4.Email Address5.Is an Adult
                  */

    }
}
