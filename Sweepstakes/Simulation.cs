using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public MarketingFirm marketFirm;
        
        public void CreateMarketingFirmWithManager()
        {
            MarketingFirm marketFirm = new MarketingFarm();
            ISweepstakesManager manager;
            Console.WriteLine("Choose between 1)SweepstakesStackManager or 2)SweepstakesQueueManager");
            string userChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case 0:
                    manager = SweepstakesStackManager;
                    break;
                case 1:
                    manager = SweepstakesQueueManager;
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
        }
    }
}
