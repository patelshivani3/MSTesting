using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTesting;
using System;

namespace MSTestProject
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [TestCategory ("Addition")]
        [DataRow(10 , 20 , 30)]
        [DataRow(40 , 20 , 60)]
        public void Given_Number_Should_Return_Sum(int a ,int b ,int expected)
        {
            //AAA Methodology
            //Arrange          
            Calculator calculator= new Calculator();

            //Act
            int actual = calculator.Addition(a, b);
            Console.WriteLine("Sum Result: "+actual);
            
            //Assert - use to compare 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Substraction")]
        [DataRow(10, 20, 10)]
        [DataRow(40, 20, 20)]
        public void Given_Number_Should_Return_Difference(int a, int b, int expected)
        {
            //AAA Methodology
            //Arrange          
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Substraction(a, b);
            Console.WriteLine("Diff Result: " + actual);

            //Assert - use to compare 
            Assert.AreEqual(expected, actual);
        }
    }
}
