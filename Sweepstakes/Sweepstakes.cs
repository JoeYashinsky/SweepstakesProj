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

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            int sweepstakesWinner;
            sweepstakesWinner = 
            Console.WriteLine("The winner of the sweepstakes is {Contestant.FirstName} + {Contestant.LastName}");
            return sweepstakesWinner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.FirstName);
            Console.WriteLine(contestant.LastName);
            Console.WriteLine(contestant.EmailAddress);
            Console.WriteLine(contestant.RegistrationNumber);
        }
    }
}
