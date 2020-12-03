using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        private string name;
        public string Name { get { return name; } }
        public Dictionary<int, Contestant> contestants;    //type of Key, type of Value

        public Sweepstakes(string sweepstakesName)
        {
            contestants = new Dictionary<int, Contestant>();
            name = sweepstakesName;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public Contestant PickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
