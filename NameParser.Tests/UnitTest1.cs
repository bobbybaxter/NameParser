using System;
using Xunit;

namespace NameParser.Tests
{
    public class NameParsingTests
    {
        [Fact] // attribute of the below element, in this case a method; adds metadata
        public void FirstAndLastNameShouldBeParsedAccurately()  // always public, always void, always verbose naming, never takes arguments
        {
            //Arrange
            var name = "Martin Cross";
            var parser = new Parser();

            //Act
            var result = parser.ParseName(name);

            //Assert
            Assert.Equal("Martin", result.FirstName);
            Assert.Equal("Cross", result.LastName);
        }

        [Fact]
        public void ThreePartNamesShouldBeParsedAccurately()
        {
            //Arrange
            var name = "Martin Zachariah Cross";
            var parser = new Parser();

            //Act
            var result = parser.ParseName(name);

            //Assert
            Assert.Equal("Martin", result.FirstName);
            Assert.Equal("Cross", result.LastName);
        }
    }
}
