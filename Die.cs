using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Class_Task
{
    public interface IRollable //Interface to roll dice
    {
        int Roll();
    }

    class Die : IRollable //Implements the IRollable interface
    {
        private Random random = new Random(); //Random object to generate random numbers
        public int CurrentValue { get; set;} //Property to hold the current value of the dice

        public int Roll() //Method to roll dice with no parameters and returns the current value of the dice
        {
            CurrentValue = random.Next(1, 7); //Edit values for Testing in testing module. Choooses random number between 1 and 6
            return CurrentValue; //Returns the current value of the dice
        }
    }
}
