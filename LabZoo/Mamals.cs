using System;
namespace LabZoo
{
    public abstract class Mamal : Animal
    {
        public override int SleepHours()
        {
            return 8;
        }
        public virtual bool Marsupial { get; set; }
        public virtual bool Swimmer => true;
        public override string FightOrFlight => "fight";
        public override string SleepType => "dinural";
        public override string FoodSearch()
        {
            return "I'm hungry. I'll search for food.";
        }
    }

    public class Carnivor : Mamal
    {
        public override string FoodSearch()
        {
            base.FoodSearch();
            return "I'll hunt for an animal to eat!";
        }
    }

    public class Herbavor : Mamal
    {
        public override string FoodSearch()
        {
            base.FoodSearch();
            return "I'll find some plants to eat!";
        }
    }

    class Kangeroo : Herbavor
    {
        public override bool Marsupial => true;
    }

    public class Bat : Mamal, IFlight, ISwim
    {
        public int FlightDistance => 500;

        public int FlightSpeed => 35;

        public int SwimSpeed => 2;

        public int SwimDistance => 10;

        public string Swim()
        {
            return "I can kind of swim";
        }
    }

    public class Bear : Mamal, ISwim
    {
        public int SwimSpeed => 5;

        public int SwimDistance => 50;

        public string Swim()
        {
            return "I can swim";
        }
    }
}