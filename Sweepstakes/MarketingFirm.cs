using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
   public class MarketingFirm
    {
        public ISweepstakesManager _manager;

        // Marketing Firm should be able to utilize an ISweepstakesManager, be that EITHER StackManager or QueueManager.
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        public void CreateSweepstake()
        {
             Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetUserInputFor("What is the title of this sweepstakes?"));
            _manager.InsertSweepstakes(sweepstakes);
        }
    }
}
//in userinterface class
//public static string GetUserInputFor(string prompt)
//{
//    Console.WriteLine(prompt);
//    return Console.ReadLine();

//Create a MarketingFirm class with functionality to create a sweepstakes.

//Implement dependency injection in this MarketingFirm class in order to utilize a sweepstakes manager.

