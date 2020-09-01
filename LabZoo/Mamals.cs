using System;
namespace LabZoo
{

    class Mamals : Animals
    {
        public bool Carnivorous { get; set; }

        public bool Marsupial => false;

        public override string Eat()
        {
            return "Eats food";
        }

        public override bool Nocturnal()
        {
            return false;
        }

        public override string Sounds()
        {
            return "Makes a Noise";
        }
    }

    class Tiger : Mamals
    {
        public override string Eat()
        {
            return "Eats Carole Baskin";
        }

        public override bool Nocturnal() => false;

        public override string Sounds()
        {
            return "Rawr";
        }
    }

    class Kangaroo : Mamals
    {
        public override string Eat()
        {
            return "Eats Grass";
        }

        public override bool Nocturnal() => false;

        public override string Sounds()
        {
            return "Kangaroo noise";
        }
    }
}