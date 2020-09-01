using System;
using LabZoo;
using Xunit;
using static LabZoo.Amphibian;

namespace ZooTests
{
    public class AnimalTests
    {
        [Fact]
        public void Kangeroo_has_correct_attributes()
        {
            //Arange and Act
            Herbavor Kangeroo = new Herbavor();
            Kangeroo.Marsupial = true;
            //Assert
            string expectedFood = "I'll find some plants to eat!";
            Assert.Equal(expectedFood, Kangeroo.FoodSearch());
            Assert.True(Kangeroo.Marsupial);
            Assert.True(Kangeroo.Swimmer);
            Assert.Equal("fight", Kangeroo.FightOrFlight);
        }
        [Fact]
        public void Lizard_has_correct_attributes()
        {
            //Arange and Act
            Arboreal lizard = new Arboreal();
            lizard.Scales = true;
            //Assert
            string expectedFood = "I'm looking for bugs";
            Assert.Equal(expectedFood, lizard.FoodSearch());
            Assert.True(lizard.Scales);
            Assert.Equal(12, lizard.SleepHours());
        }
        [Fact]
        public void Robin_has_correct_attributes()
        {
            //Arange and Act
            Flight robin = new Flight();
            //Assert 
            string expectedMovement = "I flap my wings and fly";
            Assert.Equal(expectedMovement, robin.Movement());
            Assert.Equal(6, robin.SleepHours());
        }

        [Fact]
        public void Cobra_hiss()
        {
            //Arange and Act
            Cobra bill = new Cobra();
            //Assert 
            Assert.Equal("hiss", bill.Sounds());
        }
    }
}
 