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

    public abstract class Flight : Bird, IFlight
    {
        public abstract int FlightDistance { get; }

        public abstract int FlightSpeed { get; } 

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

        public class BaldEagle : Flight, IFlight
        {
        public override int FlightDistance => 300; 

        public override int FlightSpeed => 100;

        public override string Home()
            {
                return "The great down under";
            }
        }
    
}
