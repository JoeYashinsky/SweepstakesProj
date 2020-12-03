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
            Console.WriteLine("Please provide your first name: ");
            string firstName = Console.ReadLine();
            return firstName;
        }
        public static string AssignLastName()
        {
            Console.WriteLine("Please provide your last name: ");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public static string AssignEmailAddress()
        {
            Console.WriteLine("Please provide your email address: ");
            string emailAddress = Console.ReadLine();
            return emailAddress;
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


