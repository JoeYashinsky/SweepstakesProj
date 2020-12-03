using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
       public string FirstName;
       public string LastName;
       public string EmailAddress;
       public int RegistrationNumber;

    public Contestant()
        {
            FirstName = UserInterface.AssignFirstName();
            LastName = UserInterface.AssignLastName();
            EmailAddress = UserInterface.AssignEmailAddress();
            RegistrationNumber = UserInterface.AssignRegistrationNumber();
        }
       
           
    }
}
//Create a User Interface for any information the application would need to get from the user. One example would be functionality
// to assign a Contestant object a first name, last name, email address, and registration number.
//utilize UserInterface methods to retrieve firstName, lastName, etc.
