using System;
using Xunit;
using OhmCalculationClassLibrary;
namespace OhmCalculationLibraryTest
{
    public class UnitTest1
    {
        [Fact]
        public void CalculationShouldReturnOneHunderedTen()
        {           
            OhmCalculator calc = new OhmCalculator();
            int result = calc.CalculateOhmValue("brown", "brown", "brown", "brown");
            Assert.Equal(110, result);
             
        }

        [Fact]
        public void CalculationShouldReturnFourTrillion()
        {
            string bandAColor = "black";
            string bandBColor = "yellow";
            string bandCColor = "white";
            string bandDColor = "gold";

            int ohmCalculated = 0;

            if (bandAColor != null && bandBColor != null && bandCColor != null && bandDColor != null)
            {

                // get color values from dictionaries, turn them into strings, append bandA + bandB and turn the string into an int.
                String bandAString = string.Format("{0}", BandValueDictionary.Instance.bandsAB_SignifacantFigure[bandAColor]);
                String bandBString = string.Format("{0}", BandValueDictionary.Instance.bandsAB_SignifacantFigure[bandBColor]);

                if (Int32.TryParse((bandBString + bandBString), out int n))
                {
                    int ohmResistanceValue = Convert.ToInt32(bandBString + bandBString);
                    int bandCMultiplier = BandValueDictionary.Instance.bandC_DecimalMultiplier[bandCColor];
                    ohmCalculated = ohmResistanceValue * (int)Math.Pow(10, bandCMultiplier);
                }
                else
                {
                    //OH NOES!!!
                    //TODO: create some sort of exception handeling
                }

            }

        }

        [Fact]
        public void CalculationShouldReturnFourHunderedFortyK()
        {
            OhmCalculator calc = new OhmCalculator();
            int result = calc.CalculateOhmValue("yellow", "yellow", "yellow", "gold");
            Assert.Equal(440000, result);
        }

       /* [Fact]
        public void ShouldThrowINeedsThatNumberException()
        {
            OhmCalculator calc = new OhmCalculator();
            int result = calc.CalculateOhmValue(null, null, null, null);
            Assert.Equal(440000, result);
        }*/


    }


}
