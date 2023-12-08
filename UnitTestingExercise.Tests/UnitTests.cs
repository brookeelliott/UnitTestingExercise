using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(6, 1, 2, 9)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new Calculator();


            //Act
            var actual = test.Add(num1, num2, num3);
            // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 1, 3)]
        [InlineData(12, 3, 9)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subTest = new Calculator();

            //Act
            var actual2 = subTest.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual2);
        }

        [Theory]
        [InlineData(8, 1, 8)]
        [InlineData(12, 3, 36)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multTest = new Calculator();

            //Act
            var actual3 = multTest.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual3);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(12, 6, 2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divTest = new Calculator();

            //Act
            var actual4 = divTest.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual4);
        }

    }
}
