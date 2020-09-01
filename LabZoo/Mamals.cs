using System;
namespace LabZoo
{
    class Mamals : Animal
    {
        public bool FurPattern { get; set; }
        public bool SwimAbility { get; set; }

        public override string Eat { get; }

        public override string Sleep { get; }

        public override string Sounds { get; }
    }

    class Tiger : Mamals
    {
        public override string Eat => "Meat";

        public override string Sleep => "Dinurnal";

        public override string Sounds => "Rawr";
    }
}