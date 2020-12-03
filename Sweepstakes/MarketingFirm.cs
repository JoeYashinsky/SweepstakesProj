using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public ISweepstakesManager _manager;

        // Marketing Firm should be able to utilize an ISweepstakesManager, be that EITHER StackManager or QueueManager.
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        public void CreateSweepstake()
        {

        }
    }
}

//Create a MarketingFirm class with functionality to create a sweepstakes.

//Implement dependency injection in this MarketingFirm class in order to utilize a sweepstakes manager.

