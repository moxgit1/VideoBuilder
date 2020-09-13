using System;
using Xunit;
using Xunit.Extensions;
using System.Text;
using System.Globalization;

namespace TestProject
{

    public class DrinkTests
    {

        [Fact]
        public void TestGrapeJuice_Carbonated_IsFalse()
        {
            var  juice = new Juice("Grape", "my grape juice");
            Assert.Equal(false, juice.IsCarbonated);
        }

        [Fact]
        public void TestPearJuice_FruitType_IsSame()
        {
            var juice = new Juice("Pear", "my pear juice");
            Assert.Equal("Pear", juice.Name);
        }

        [Fact]
        public void TestSoda_Carbonated_IsTrue()
        {
            var soda = new Soda("Pepsi");
            Assert.Equal(true, soda.IsCarbonated);
        }

        [Fact]
        public void TestSoda_Description_Carbonated()
        {
            var soda = new Soda("Pepsi");
            Assert.Equal("carbonated", soda.CarbonatedDescription);
        }

        [Fact]
        public void TestBeer_AlcoholContent_20Percent()
        {
            var beer = new Beer("Heineken", "20%");
            Assert.True(String.Equals("20%",  beer.AlcoholContent, StringComparison.OrdinalIgnoreCase));
        }
    }
}
