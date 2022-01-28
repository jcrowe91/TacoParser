using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {         
                      
            var tacoParser = new TacoParser();                   
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");          
            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {                                  
            var parser = new TacoParser();      
            var actual = parser.Parse(line);      
            Assert.Equal(actual.Location.Longitude, expected);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expected)
        {                    
            var parser = new TacoParser();      
            var actual = parser.Parse(line);      
            Assert.Equal(actual.Location.Latitude, expected);
        }


        #region INSTRUCTIONS
        // TODO: Complete Something, if anything
        // TODO: Complete - "line" represents input data we will Parse to
        //       extract the Longitude.  Your .csv file will have many of these lines,
        //       each representing a TacoBell location
        // TODO: Complete - "line" represents input data we will Parse to
        //       extract the Longitude.  Your .csv file will have many of these lines,
        //       each representing a TacoBell location
        //TODO: Create a test ShouldParseLatitude
        #endregion
    }
}
