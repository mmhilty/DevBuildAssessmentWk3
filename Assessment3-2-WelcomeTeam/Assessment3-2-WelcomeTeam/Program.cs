using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3_2_WelcomeTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamMember> personlist = new List<TeamMember>();
            bool killswitch = true;
            while (killswitch)
            {
                Console.WriteLine("What would you like to do? \n" +
                    "1. View list of Team Members\n" +
                    "2. Add a Team Member\n" +
                    "3. Quit");

                string mainmenuinput = Console.ReadLine();

                switch (mainmenuinput)
                {
                    case "1":
                        foreach (TeamMember t in personlist)
                            Console.WriteLine($"\nName: {t.firstname} {t.lastname}\n" +
                                $"Age: {t.age}\n" +
                                $"Email: {t.email}\n" +
                                $"Salary: {t.salary}\n");
                        break;
                    case "2":
                        personlist.Add(TeamMember.CreatePerson());
                        break;
                    case "3":
                        killswitch = false;
                        break;
                    default:
                        Console.WriteLine("Not an option.");
                        break;


                }
            }

        }
    }
}
