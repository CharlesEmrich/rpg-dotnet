using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using RPG.Models;

namespace RPG.Tests.ModelTests
{
    public class RoomTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var room = new Room();
            room.Description = "Black Lodge";
        
            //Act
            var result = room.Description;

            // Assert
            Assert.Equal("Black Lodge", result);
        }
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var room = new Room();
            room.Name = "A Void Between Places";

            //Act
            var result = room.Name;

            // Assert
            Assert.Equal("A Void Between Places", result);
        }
    }
}
