using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Calc_test
{
    [TestFixture]
    public class Calculatortest
    {
        private MathLogic Calculator;
        public Calculatortest()
        {
            Calculator = new MathLogic();
        }
        [Test]
        public void AddTest()
        {
            int result = Calculator.Add(3, 4);
            Assert.That(result, Is.EqualTo(7));

        }
        [Test]
        public void Subtract()
        {
            int result = Calculator.Subtract(10, 4);
            Assert.That(result, Is.EqualTo(6));
        }
        [Test]
        public void Multiply()
        {
            int result = Calculator.Multiply(3, 4);
            Assert.That(result, Is.EqualTo(12));
        }
        [Test]
        public void Divide()
        {
            int result = Calculator.Divide(12, 4);
            Assert.That(result, Is.EqualTo(3));

        }
        [Test]
        public void DivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(12, 0));
        }
    }
}
