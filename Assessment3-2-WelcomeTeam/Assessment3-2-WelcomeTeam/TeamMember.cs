using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assessment3_2_WelcomeTeam
{
    class TeamMember : Person
    {
        public double salary;


        public TeamMember(string firstname, string lastname, int age, string email, double salary) : base(firstname, lastname, age, email)
        {
            this.salary = salary;
            
        }

        public static new TeamMember CreatePerson()
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
            double inputsalary;
            while (true)
            {
                if (double.TryParse(StringGetter.Get("Enter the salary:"), out inputsalary))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid entry. Please enter a number");
                }
            }

            return new TeamMember(inputfirst, inputlast, inputage, inputemail, inputsalary);
        }

        //           while (true)
        //            {
        //                if (double.TryParse(StringGetter.Get("Enter the age:"), out salary))
        //                {
        //                    break;
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Not a valid entry. Please enter a whole number");
        //                }
        //}


    }
}
