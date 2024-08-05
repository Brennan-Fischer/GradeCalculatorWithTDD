
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeCalculator;


namespace CalculatorTester
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(90, 'A')]
        [InlineData(95, 'A')]
        public void CalculateGrade_ReturnsA_ForScores90to100(int score, char expectedGrade)
        {

            char result = Calculator.CalculateGrade(score);
            Assert.Equal(expectedGrade, result);
        }

        [Theory]
        [InlineData(80, 'B')]
        [InlineData(85, 'B')]
        public void CalculateGrade_ReturnsB_ForScores80to89(int score, char expectedGrade)
        {
            char result = Calculator.CalculateGrade(score);
            Assert.Equal(expectedGrade, result);
        }

        [Theory]
        [InlineData(70, 'C')]
        [InlineData(75, 'C')]
        public void CalculateGrade_ReturnsC_ForScores70to79(int score, char expectedGrade)
        {
            char result = Calculator.CalculateGrade(score);
            Assert.Equal(expectedGrade, result);
        }

        [Theory]
        [InlineData(60, 'D')]
        [InlineData(65, 'D')]
        public void CalculateGrade_ReturnsD_ForScores60to69(int score, char expectedGrade)
        {
            char result = Calculator.CalculateGrade(score);
            Assert.Equal(expectedGrade, result);
        }

        [Theory]
        [InlineData(50, 'F')]
        [InlineData(59, 'F')]
        public void CalculateGrade_ReturnsF_ForScoresBelow60(int score, char expectedGrade)
        {
            char result = Calculator.CalculateGrade(score);
            Assert.Equal(expectedGrade, result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(101)]
        public void CalculateGrade_ThrowsArgumentOutOfRangeException_ForInvalidScores(int score)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.CalculateGrade(score));
        }
    }

}



