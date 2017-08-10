using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using RPG.Models;

namespace RPG.Tests.ModelTests
{
    public class DoorTest
    {
        [Fact]
        public void GetShapeTest()
        {
            //Arrange
            var door = new Door();
            door.Shape = "Round";

            //Act
            var result = door.Shape;

            // Assert
            Assert.Equal("Round", result);
        }

        [Fact]
        public void GetColorTest()
        {
            //Arrange
            var door = new Door();
            door.Color = "Red";

            //Act
            var result = door.Color;

            // Assert
            Assert.Equal("Red", result);
        }

        [Fact]
        public void GetSizeTest()
        {
            //Arrange
            var door = new Door();
            door.Size = "Small";

            //Act
            var result = door.Size;

            // Assert
            Assert.Equal("Small", result);
        }
    }
}
