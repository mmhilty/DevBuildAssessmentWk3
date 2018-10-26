using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3_1_MyPeeps
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personlist = new List<Person>();
            bool killswitch = true;
            while (killswitch)
            { 
            Console.WriteLine("What would you like to do? \n" +
                "1. View list of people\n" +
                "2. Add a person\n" +
                "3. Quit");

                string mainmenuinput = Console.ReadLine();

                switch (mainmenuinput)
                {
                    case "1":
                        foreach(Person p in personlist)
                            Console.WriteLine($"\nName: {p.firstname} {p.lastname}\n" +
                                $"Age: {p.age}\n" +
                                $"Email: {p.email}\n" +
                                $"Adult? {p.isadult}\n");
                        break;
                    case "2":
                        personlist.Add(Person.CreatePerson());
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
