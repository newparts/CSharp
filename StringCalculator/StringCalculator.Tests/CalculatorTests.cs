using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringCalculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("1,2", 3)]
        public void Add_AddsUpToTwoNumber_WhenStringIsValid(string calculation, int expected)
        {
            // Arrange
            var systut = new Calculator();

            // Act
            var result = systut.Add(calculation);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("1,2,3,4", 10)]
        [InlineData("20,80,40,60", 200)]
        public void Add_AddsUpToAnyNumber_WhenStringIsValid(string calculation, int expected)
        {
            // Arrange
            var systut = new Calculator();

            // Act
            var result = systut.Add(calculation);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("1\n2,3,4", 10)]
        [InlineData("20\n80,40\n60", 200)]
        public void Add_AddsNumbersUsingNewLineDelimiter_WhenStringIsValid(string calculation, int expected)
        {
            // Arrange
            var systut = new Calculator();

            // Act
            var result = systut.Add(calculation);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("//;\n1;2", 3)]
       
        public void Add_AddsNumbersUsingCustomDelimiter_WhenStringIsValid(string calculation, int expected)
        {
            // Arrange
            var systut = new Calculator();

            // Act
            var result = systut.Add(calculation);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("1,2,-1", "-1")]
        [InlineData("//;\n1;-2;-4", "-2,-4")]
        public void Add_ShouldThrowAnException_WhenNegativeNumbersAreUsed(string calculation, string negativeNumbers)
        {
            // Arrange
            var systut = new Calculator();

            // Act
            Action action = () => systut.Add(calculation);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage("Negatives not allowed: " + negativeNumbers);
        }

        [Theory]
        [InlineData("1001", 0)]
        [InlineData("1,1001",  1)]
       
        public void Add_ShouldReturnsCorrectSum_WhenIgnoringNumbersGreaterThanOneThousand(string calculation, int expected)
        {
            // Arrange
            var systut = new Calculator();

            // Act
            var result = systut.Add(calculation);

            // Assert
            result.Should().Be(expected);
           
        }
    }
}
