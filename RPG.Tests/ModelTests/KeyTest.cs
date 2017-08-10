using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using RPG.Models;

namespace RPG.Tests.ModelTests
{
    public class KeyTest
    {
        [Fact]
        public void GetShapeTest()
        {
            //Arrange
            var key = new Key();
            key.Shape = "Twisted";

            //Act
            var result = key.Shape;

            // Assert
            Assert.Equal("Twisted", result);
        }

        [Fact]
        public void GetColorTest()
        {
            //Arrange
            var key = new Key();
            key.Color = "Fuchsia";

            //Act
            var result = key.Color;

            // Assert
            Assert.Equal("Fuchsia", result);
        }

        [Fact]
        public void GetSizeTest()
        {
            //Arrange
            var key = new Key();
            key.Size = "Huge";

            //Act
            var result = key.Size;

            // Assert
            Assert.Equal("Huge", result);
        }
    }
}
