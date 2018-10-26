using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3_2_WelcomeTeam
{
    class StringGetter
    {
        public static string Get(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            return userInput;
        }

    }
}
