using System;

namespace LabZoo
{
    abstract class Animal
    {
        public abstract int Mass { get; set; }
        public abstract string FoodType { get; set; }
        public abstract string SleepType { get; set; }

        public abstract string FoodSearch();
        public abstract string FoodSearch();

    }
}
