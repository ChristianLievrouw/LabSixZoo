using System;
namespace LabZoo
{
    public class Bird : Animal
    {
        public override string SleepType => "dinural";
        
        public override string FoodSearch()
        {
            return "I'm looking for food with a bird's eye view";
        }

        public override int SleepHours()
        {
            return 6 ;
        }

        public override string FightOrFlight => "flight";
    }
        public class Flight : Bird
        {
            public override string Movement()
            {
                return "I flap my wings and fly";
            }
        }

        public class Flightless : Bird
        {
            public override string Movement()
            {
                return "I might flap my wings, but I'll never fly";
            }
        }

        class Emu : Flightless
        {
            public override string Home()
            {
                return "The great down under";
            }
        }

        class BladEagle : Flight
        {
            public override string Home()
            {
                return "The great down under";
            }
        }
    
}
