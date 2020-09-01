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
            BaldEagle baldEagle = new BaldEagle();
            //Assert 
            string expectedMovement = "I flap my wings and fly";
            Assert.Equal(expectedMovement, baldEagle.Movement());
            Assert.Equal(6, baldEagle.SleepHours());
            Assert.Equal(300, baldEagle.FlightDistance);
        }

        [Fact]
        public void Cobra_hiss()
        {
            //Arange and Act
            Cobra bill = new Cobra();
            //Assert 
            Assert.Equal("hiss", bill.Sounds());
        }

        [Fact]
        public void Mammal_swim_tests()
        {
            Bear bear = new Bear();


            Assert.Equal(5, bear.SwimSpeed);
            Assert.Equal("I can swim", bear.Swim());
            Assert.Equal("I'm an animal", bear.Statement());
        }

        [Fact]
        public void Bat_swims_and_flies()
        {
            //Arange and act
            Bat bat = new Bat();
            //Assert
            Assert.Equal(500, bat.FlightDistance);
            Assert.Equal(60, bat.FlightSpeed);
            Assert.Equal(10, bat.SwimDistance);
            Assert.Equal(2, bat.SwimSpeed);
            Assert.Equal("I can kind of swim!", bat.Swim());
        }
    }
}
 