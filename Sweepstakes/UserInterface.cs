using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static string AssignFirstName()
        {

        }
        public static string AssignLastName()
        {

        }
        public static string AssignEmailAddress()
        {

        }
        public static int AssignRegistrationNumber()
        {

        }
    }
}

//Create a user interface for any information the application would need to get from the user
//One example would be the functionality to assign a Contestant object a
// -first name
// -last name
// -email address
// -registration number


