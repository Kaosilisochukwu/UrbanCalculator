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
            var tester = new CalculationFactory();
            string firstNumberString = "67";
            string secondNumberString = "10";

            var expected = tester.AdditionOperation(firstNumberString, secondNumberString);
            Assert.That(expected, Is.EqualTo("77"));
        }

        [Test]
        public void AllMethodsThrowForInvalidNumberStringInput()
        {
            var tester = new CalculationFactory();
            string firstNumberString = "r7";
            string secondNumberString = "10";
           
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
            var tester = new CalculationFactory();
            string firstNumberString = "6";
            string secondNumberString = "10";

            var expected = tester.MultiplyOperation(firstNumberString, secondNumberString);
            Assert.That(expected, Is.EqualTo("60"));
        }
        [Test]
        public void ToTestThatSubtractionMethodReturnsCorrectStringValueOfSubtractingTwoStrings()
        {
            var tester = new CalculationFactory();
            string firstNumberString = "67";
            string secondNumberString = "10";

            var expected = tester.SubtractionOperation(firstNumberString, secondNumberString);
            Assert.That(expected, Is.EqualTo("57"));
        }
        [Test]
        public void ToTestThatDivisionMethodReturnsCorrectStringValueOfDividingTwoStrings()
        {
            var tester = new CalculationFactory();
            string firstNumberString = "60";
            string secondNumberString = "10";

            var expected = tester.DivisionOperation(firstNumberString, secondNumberString);
            Assert.That(expected, Is.EqualTo("6"));
        }

        [Test]
        public void NegateOperatorChangesNegativeNumberStringToPositiveNumberString()
        {
            var tester = new CalculationFactory();
            string firstNumberString = "-34";

            var expected = tester.NegationOperation(firstNumberString);
            Assert.That(expected, Is.EqualTo("34"));
        }

        public void NegateOperatorChangesPositiveNumberStringToNegativetiveNumberString()
        {
            var tester = new CalculationFactory();
            string firstNumberString = "34";

            var expected = tester.NegationOperation(firstNumberString);
            Assert.That(expected, Is.EqualTo("-34"));
        }

        [Test]
        public void ToTestForZeroDivision()
        {
            var tester = new CalculationFactory();
            string firstNumberString = "60";
            string secondNumberString = "0";

            Assert.Throws<DivideByZeroException>(
                () => tester.DivisionOperation(firstNumberString, secondNumberString)
                );
        }
    }
}