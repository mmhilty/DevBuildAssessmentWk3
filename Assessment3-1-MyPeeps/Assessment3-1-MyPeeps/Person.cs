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
                /// I FULLY ADMIT that I didn't come up with this specific regex pattern myself and used one from regexlib.com. 
                /// Shoutout to Steven Smith. Everything else is fully homegrown, however. 
                /// if not using homegrown regex patterns is verboten, please remove this validation section and replace it with
                /// string inputemail = StringGetter.Get("Enter the email:");
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
