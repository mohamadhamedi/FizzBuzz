using FizzBuzz;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzUnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutputString_InputIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.FizzBuzz.GetOutputString(15);

            Assert.That(result,
                        Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void GetOutputString_InputIsDivisibleBy3_ReturnFizz()
        {
            var result = FizzBuzz.FizzBuzz.GetOutputString(3);

            Assert.That(result,
                        Is.EqualTo("Fizz"));
        }
        [Test]
        public void GetOutputString_InputIsDivisibleBy5_ReturnBuzz()
        {
            var result = FizzBuzz.FizzBuzz.GetOutputString(5);

            Assert.That(result,
                        Is.EqualTo("Buzz"));
        }
        [Test]
        public void GetOutputString_InputIsNotDivisibleBy3Or5_ReturnSameNumber()
        {
            var result = FizzBuzz.FizzBuzz.GetOutputString(11);

            Assert.That(result,
                        Is.EqualTo("11"));
        }
    }
}
