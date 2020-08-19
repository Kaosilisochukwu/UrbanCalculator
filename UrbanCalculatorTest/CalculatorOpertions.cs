using NUnit.Framework;
using System;
using UrbanCalculator;

namespace UrbanCalculatorTest
{
    public class Tests
    {

        [Test]
        public void ToTestThatAddtionMethodReturnsCorrectStringValueOfAddingTwoStrings()
        {
            //ARRANGE
            var tester = new CalculationFactory();
            string firstNumberString = "67";
            string secondNumberString = "10";

            //ACT
            var expected = tester.AdditionOperation(firstNumberString, secondNumberString);

            //ASSERT
            Assert.That(expected, Is.EqualTo("77"));
        }

        [Test]
        public void AllMethodsThrowForInvalidNumberStringInput()
        {
            //ARRANGE
            var tester = new CalculationFactory();
            string firstNumberString = "r7";
            string secondNumberString = "10";
           
            //ACT & ASSERT
            Assert.Throws<ArgumentException>(
                () => tester.AdditionOperation(firstNumberString, secondNumberString)
                );
            Assert.Throws<ArgumentException>(
                () => tester.MultiplyOperation(firstNumberString, secondNumberString)
                );
            Assert.Throws<ArgumentException>(
                () => tester.DivisionOperation(firstNumberString, secondNumberString)
                );
            Assert.Throws<ArgumentException>(
                () => tester.SubtractionOperation(firstNumberString, secondNumberString)
                );
            Assert.Throws<ArgumentException>(
                () => tester.NegationOperation(firstNumberString)
                );
        }


        [Test]
        public void ToTestThatMultiplicationMethodReturnsCorrectStringValueOfMultiplyingTwoStrings()
        {
            //ARRANGE
            var tester = new CalculationFactory();
            string firstNumberString = "6";
            string secondNumberString = "10";

            //ACT
            var expected = tester.MultiplyOperation(firstNumberString, secondNumberString);

            //ASSERT
            Assert.That(expected, Is.EqualTo("60"));
        }
        [Test]
        public void ToTestThatSubtractionMethodReturnsCorrectStringValueOfSubtractingTwoStrings()
        {
            //ARRANGE
            var tester = new CalculationFactory();
            string firstNumberString = "67";
            string secondNumberString = "10";

            //ACT 
            var expected = tester.SubtractionOperation(firstNumberString, secondNumberString);

            //ASSERT
            Assert.That(expected, Is.EqualTo("57"));
        }
        [Test]
        public void ToTestThatDivisionMethodReturnsCorrectStringValueOfDividingTwoStrings()
        {
            //ARRANGE
            var tester = new CalculationFactory();
            string firstNumberString = "60";
            string secondNumberString = "10";

            //ACT
            var expected = tester.DivisionOperation(firstNumberString, secondNumberString);

            //ASSERT
            Assert.That(expected, Is.EqualTo("6"));
        }

        [Test]
        public void NegateOperatorChangesNegativeNumberStringToPositiveNumberString()
        {
            //ARRANGE
            var tester = new CalculationFactory();
            string firstNumberString = "-34";

            //ACT
            var expected = tester.NegationOperation(firstNumberString);

            //ASSERT
            Assert.That(expected, Is.EqualTo("34"));
        }

        public void NegateOperatorChangesPositiveNumberStringToNegativetiveNumberString()
        {
            //ARRANGE
            var tester = new CalculationFactory();
            string firstNumberString = "34";

            //ACT
            var expected = tester.NegationOperation(firstNumberString);

            //ASSERT
            Assert.That(expected, Is.EqualTo("-34"));
        }

        [Test]
        public void ToTestForZeroDivision()
        {
            //ARRANGE
            var tester = new CalculationFactory();
            string firstNumberString = "60";
            string secondNumberString = "0";

            //ACT & ASSERT
            Assert.Throws<DivideByZeroException>(
                () => tester.DivisionOperation(firstNumberString, secondNumberString)
                );
        }
    }
}