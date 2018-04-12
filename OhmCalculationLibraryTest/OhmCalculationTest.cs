using System;
using Xunit;

using System.Collections.Generic;
using OhmCalculationClassLibrary;
using OhmCalculationClassLibrary.ExceptionHandling;

namespace OhmCalculationLibraryTest
{
    public class OhmCalUnitTest
    {
        /// <summary>
        /// Tests for 10 Ohms.
        /// </summary>
        [Fact]
        public void CalculationShouldReturnOneThousand()
        {
            OhmCalculator calculator = new OhmCalculator();
            int result = calculator.CalculateOhmValue("brown", "black", "black", "silver");            
            Assert.Equal(10, result);
        }

        /// <summary>
        /// Tests for 100 Ohms.
        /// </summary>
        [Fact]
        public void CalculationShouldReturnOneHundred()
        {
            OhmCalculator calculator = new OhmCalculator();
            int result = calculator.CalculateOhmValue("brown", "black", "brown", "silver");
            Assert.Equal(100, result);
        }

        /// <summary>
        /// Tests for 1000 Ohms.
        /// </summary>
        [Fact]
        public void CalculationShouldReturnTen()
        {
            OhmCalculator calculator = new OhmCalculator();
            int result = calculator.CalculateOhmValue("brown", "black", "red", "silver");
            Assert.Equal(1000, result);
        }

        /// <summary>
        /// Tests empty.
        /// </summary>
        [Fact]
        public void CalculationShouldThrowException()
        {
            OhmCalculator calculator = new OhmCalculator();
            Assert.Throws<BandCantBeEmptyOrNullException>(() => calculator.CalculateOhmValue("", "", "red", "silver"));
        }

        /// <summary>
        /// Tests if keys exist.
        /// </summary>
        [Fact]
        public void asdf()
        {
            OhmCalculator calculator = new OhmCalculator();
            Assert.Throws<KeyNotFoundException>(() => calculator.CalculateOhmValue("fu", "bar", "bazz", "quandary"));
        }

        /// <summary>
        /// Tests null.
        /// </summary>
        [Fact]
        public void fsad()
        {
            OhmCalculator calculator = new OhmCalculator();
            Assert.Throws<BandCantBeEmptyOrNullException>(() => calculator.CalculateOhmValue(null, "", "red", "silver"));
        }

        /// <summary>
        /// Tests .
        /// </summary>
        [Fact]
        public void CalculationShouldReturnOneHunderedTen()
        {
            OhmCalculator calculator = new OhmCalculator();
            int result = calculator.CalculateOhmValue("brown", "brown", "brown", "brown");
            Assert.Equal(110, result);
        }

        /// <summary>
        /// Tests .
        /// </summary>
        [Fact]
        public void CalculationShouldReturNintyNineBillion()
        {
            OhmCalculator calculator = new OhmCalculator();
            int result = calculator.CalculateOhmValue("white", "white", "white", "white");
            Assert.Equal(99000000, result);
        }

        /// <summary>
        /// Tests .
        /// </summary>
        [Fact]
        public void CalculationShouldReturnEightMillionTwoHundredThousand()
        {
            OhmCalculator calculator = new OhmCalculator();
            int result = calculator.CalculateOhmValue("gray", "red", "gray", "silver");         
            Assert.Equal(8200000, result);
        }
        /// <summary>
        /// Tests .
        /// </summary>
        [Fact]
        public void CalculationShouldReturnEightMillionEightHundredThousand()
        {
            OhmCalculator calculator = new OhmCalculator();
            int result = calculator.CalculateOhmValue("gray", "gray", "gray", "gray");
            Assert.Equal(8800000, result);
        }
        /// <summary>
        /// Tests .
        /// </summary>
        [Fact]
        public void CalculationShouldReturnFourHunderedFortyThousand()
        {
            OhmCalculator calculator = new OhmCalculator();
            int result = calculator.CalculateOhmValue("yellow", "yellow", "yellow", "gold");
            Assert.Equal(440000, result);
        }
        /// <summary>
        /// Tests .
        /// </summary>
        [Fact]
        public void CalculationShouldReturnOneMillion()
        {
            OhmCalculator calculator = new OhmCalculator();
            int result = calculator.CalculateOhmValue("brown", "black", "green", "silver");
            Assert.Equal(1000000, result);
        }             
    }
}
