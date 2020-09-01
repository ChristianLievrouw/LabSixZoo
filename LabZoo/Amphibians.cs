using System;
namespace LabZoo
{
    class Amphibians : Animals
    {
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

    class Frog : Amphibians
    {
        public override string Eat()
        {
            return "Flies";
        }

        public override bool Nocturnal() => true;

        public override string Sounds()
        {
            return "Ribet";
        }
    }
}
