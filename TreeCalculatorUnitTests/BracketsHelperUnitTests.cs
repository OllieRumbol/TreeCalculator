using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TreeCalculator;

namespace TreeCalculatorUnitTests
{
    [TestClass]
    public class BracketsHelperUnitTests
    {
        [TestInitialize]
        public void StartUp()
        {

        }

        [TestMethod]
        public void IsSymbolSurroundedWithBrackets_ReturnFalse()
        {
            //Associate
            string equation = "6-2*3";
            int indexOfSymbol = 1;

            //Act
            bool result = BracketsHelper.IsSymbolSurroundedWithBrackets(equation, indexOfSymbol);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSymbolSurroundedWithBrackets_ReturnTrue()
        {
            //Associate
            string equation = "(6-2)*3";
            int indexOfSymbol = 2;

            //Act
            bool result = BracketsHelper.IsSymbolSurroundedWithBrackets(equation, indexOfSymbol);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RemoveMostInnerBracketsFromEquation_Test1()
        {
            //Associate
            string equation = "(6-2)";
            string resultEquation = "6-2";

            //Act
            string result = BracketsHelper.RemoveMostInnerBracketsFromEquation(equation);

            //Assert
            Assert.AreEqual(resultEquation, result);
        }

        [TestMethod]
        public void RemoveMostInnerBracketsFromEquation_Test2()
        {
            //Associate
            string equation = "((5+3)+(5+3))";
            string resultEquation = "(5+3)+5+3";

            //Act
            string result = BracketsHelper.RemoveMostInnerBracketsFromEquation(equation);

            //Assert
            Assert.AreEqual(resultEquation, result);
        }
        [TestMethod]
        public void RemoveMostInnerBracketsFromEquation_Test3()
        {
            //Associate
            string equation = "√(102-2)";
            string resultEquation = "√102-2";

            //Act
            string result = BracketsHelper.RemoveMostInnerBracketsFromEquation(equation);

            //Assert
            Assert.AreEqual(resultEquation, result);
        }


        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
