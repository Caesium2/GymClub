using System;
using System.Collections.Generic;
using System.Text;

namespace GymClub
{
    public class ResistanceMachine : Equipment
    {
        private int weightStackMax;

        public int WeightStackMax
        {
            get { return weightStackMax; }
            set { weightStackMax = value; }
        }

        public ResistanceMachine(int equipmentID, string name, bool isAvailable, int weightStackMax)
            : base(equipmentID, name, isAvailable) //Subclass calls constructor of parent class before running its own 
        {
            this.weightStackMax = weightStackMax;
        }
    }
}
