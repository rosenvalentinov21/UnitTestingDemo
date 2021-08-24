using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4,3,7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(4 , 3 , 1)]
        [InlineData (10 , 5 , 5)]
        [InlineData (2 , 2 , 0)]
        [InlineData (5 , 0 , 5)]
        [InlineData(double.MaxValue , double.MaxValue , 0)]
        public void Substract_SimpleValuesShouldCalculate(double x , double y , double expected)
        {
            // Arrange

            //Act

            double actual = Calculator.Subtract(x, y);

            //Assert

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(10 , 2 , 20)]
        [InlineData(5 , 5 , 25)]
        [InlineData(double.MaxValue , 0 , 0)]
        public void Miltiply_SimpleCaluesShouldCalculate(double x , double y , double expected)
        {
            //Arrange 

            //Act

            double actual = Calculator.Multiply(x, y);

            //Assert

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Multiply_MultiplyByNegativeShouldResultInNegativeNumber()
        {
            //Arrange

            double expected = -25;

            // Act

            double actual = Calculator.Multiply(5, -5);

            //Assert

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(8,4,2)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(15, 0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Power_SimpleValuesShouldCalculate()
        {
            //Arrange
            double expected = 25;

            //Act
            double actual = Calculator.Powered(5, 2);

            //Assert 

            Assert.Equal(expected, actual);
        }



        [Theory]
        [InlineData(4 , 2 , 2)]
        [InlineData(1 , 2 , 1)]
        [InlineData(100 , 2 ,  10)]
        [InlineData(10 , 1 , 10)]
        public void SQRT_SimpleValuesShouldCalculate(double x , double root , double expected)
        {
            //Arrange 

            //Act
            double actual = Calculator.SQRT(x, root);

            //Assert
            Assert.Equal(expected, actual);
        }



    }
}
