using System;
namespace LabZoo
{
    class Birds : Animals
    {
        public int WingSpan { get; set; }

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

    class Robin : Birds
    {
        public override string Eat()
        {
            return "Eats bugs";
        }

        public override bool Nocturnal() => false;

        public override string Sounds()
        {
            return "Cherp";
        }
    }
}
