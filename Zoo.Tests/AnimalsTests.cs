using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Animals;

namespace ZooTests
{
    public class ZooTests
    {
        [Fact]
        public void Bear_has_name_diet_sound_home()
        {
            // Arrange
            GrizzlyBear bear = new GrizzlyBear();

            // Assert
            Assert.Equal("Roar", bear.Sound);
            Assert.Equal("Omnivore", bear.Diet);
            Assert.Equal("Grizzly Bear", bear.Name);
            Assert.Equal("Cave", bear.Home);
        }

        [Fact]
        public void Lion_has_name_diet_sound_home()
        {
            // Arrange
            Lion lion = new Lion();

            // Assert
            Assert.Equal("Roar", lion.Sound);
            Assert.Equal("Carnivore", lion.Diet);
            Assert.Equal("Lion", lion.Name);
            Assert.Equal("Grassland", lion.Home);
        }

        [Fact]
        public void BlueWhale_has_name_diet_sound_home()
        {
            // Arrange
            BlueWhale whale = new BlueWhale();

            // Assert
            Assert.Equal("Groan", whale.Sound);
            Assert.Equal("Carnivore", whale.Diet);
            Assert.Equal("Blue Whale", whale.Name);
            Assert.Equal("Ocean", whale.Home);
        }

        [Fact]
        public void ClownFish_has_name_diet_sound_home()
        {
            // Arrange
            ClownFish clown = new ClownFish();

            // Assert
            Assert.Equal("Chirp", clown.Sound);
            Assert.Equal("Omnivore", clown.Diet);
            Assert.Equal("Clown Fish", clown.Name);
            Assert.Equal("Anemone", clown.Home);
        }

        [Fact]
        public void GreatWhiteShark_has_name_diet_sound_home()
        {
            // Arrange
            GreatWhiteShark shark = new GreatWhiteShark();

            // Assert
            Assert.Equal("Silence", shark.Sound);
            Assert.Equal("Carnivore", shark.Diet);
            Assert.Equal("Great White Shark", shark.Name);
            Assert.Equal("Ocean", shark.Home);
        }

        [Fact]
        public void GrizzlyBear_is_an_animal_and_a_mammal()
        {
            // Arrange
            GrizzlyBear bear = new GrizzlyBear();

            // Assert
            Assert.True(bear is Animal);
        }

        [Fact]
        public void Lion_is_an_animal_and_a_mammal()
        {
            // Arrange
            Lion lion = new Lion();

            // Assert
            Assert.True(lion is Animal);
        }

        [Fact]
        public void BlueWhale_is_an_animal_and_a_mammal()
        {
            // Arrange
            BlueWhale whale = new BlueWhale();

            // Assert
            Assert.True(whale is Animal);
        }

        [Fact]
        public void ClownFish_is_an_animal_and_a_fish()
        {
            // Arrange
            ClownFish clown = new ClownFish();

            // Assert
            Assert.True(clown is Animal);
        }

        [Fact]
        public void GreatWhiteShark_is_an_animal_and_a_fish()
        {
            // Arrange
            GreatWhiteShark shark = new GreatWhiteShark();

            // Assert
            Assert.True(shark is Animal);
        }
    }
}
