using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TreeCalculator;

namespace TreeCalculatorUnitTests
{
    [TestClass]
    public class WeakestCalculationSymbolUnitTests
    {
        [TestInitialize]
        public void StartUp()
        {

        }

        [TestMethod]
        public void FromCalculations_Subtraction()
        {
            //Associate
            string equation = "7*5+6-2";
            WeakestCalculationSymbol expectedResult = new WeakestCalculationSymbol
            {
                Symbol = "-",
                index = 5,
                IsSingleLeft = false,
                IsSingleRight = false,
                equation = "7*5+6-2"
            };

            //Act
            WeakestCalculationSymbol actualResult = WeakestCalculationSymbol.FromCalculation(equation);

            //Assert
            Assert.AreEqual(expectedResult.Symbol, actualResult.Symbol);
            Assert.AreEqual(expectedResult.index, actualResult.index);
            Assert.AreEqual(expectedResult.IsSingleLeft, actualResult.IsSingleLeft);
            Assert.AreEqual(expectedResult.IsSingleRight, actualResult.IsSingleRight);
            Assert.AreEqual(expectedResult.equation, actualResult.equation);
        }

        [TestMethod]
        public void FromCalculations_Addition()
        {
            //Associate
            string equation = "10/5+2*6";
            WeakestCalculationSymbol expectedResult = new WeakestCalculationSymbol
            {
                Symbol = "+",
                index = 4,
                IsSingleLeft = false,
                IsSingleRight = false,
                equation = "10/5+2*6"
            };

            //Act
            WeakestCalculationSymbol actualResult = WeakestCalculationSymbol.FromCalculation(equation);

            //Assert
            Assert.AreEqual(expectedResult.Symbol, actualResult.Symbol);
            Assert.AreEqual(expectedResult.index, actualResult.index);
            Assert.AreEqual(expectedResult.IsSingleLeft, actualResult.IsSingleLeft);
            Assert.AreEqual(expectedResult.IsSingleRight, actualResult.IsSingleRight);
            Assert.AreEqual(expectedResult.equation, actualResult.equation);
        }

        [TestMethod]
        public void FromCalculations_Multiplication()
        {
            //Associate
            string equation = "5!/2/2*3";
            WeakestCalculationSymbol expectedResult = new WeakestCalculationSymbol
            {
                Symbol = "*",
                index = 6,
                IsSingleLeft = false,
                IsSingleRight = false,
                equation = "5!/2/2*3"
            };

            //Act
            WeakestCalculationSymbol actualResult = WeakestCalculationSymbol.FromCalculation(equation);

            //Assert
            Assert.AreEqual(expectedResult.Symbol, actualResult.Symbol);
            Assert.AreEqual(expectedResult.index, actualResult.index);
            Assert.AreEqual(expectedResult.IsSingleLeft, actualResult.IsSingleLeft);
            Assert.AreEqual(expectedResult.IsSingleRight, actualResult.IsSingleRight);
            Assert.AreEqual(expectedResult.equation, actualResult.equation);
        }

        [TestMethod]
        public void FromCalculations_Division()
        {
            //Associate
            string equation = "(10+5)/3";
            WeakestCalculationSymbol expectedResult = new WeakestCalculationSymbol
            {
                Symbol = "/",
                index = 6,
                IsSingleLeft = false,
                IsSingleRight = false,
                equation = "(10+5)/3"
            };

            //Act
            WeakestCalculationSymbol actualResult = WeakestCalculationSymbol.FromCalculation(equation);

            //Assert
            Assert.AreEqual(expectedResult.Symbol, actualResult.Symbol);
            Assert.AreEqual(expectedResult.index, actualResult.index);
            Assert.AreEqual(expectedResult.IsSingleLeft, actualResult.IsSingleLeft);
            Assert.AreEqual(expectedResult.IsSingleRight, actualResult.IsSingleRight);
            Assert.AreEqual(expectedResult.equation, actualResult.equation);
        }

        [TestMethod]
        public void FromCalculations_Power()
        {
            //Associate
            string equation = "(10*3+2)^3";
            WeakestCalculationSymbol expectedResult = new WeakestCalculationSymbol
            {
                Symbol = "^",
                index = 8,
                IsSingleLeft = false,
                IsSingleRight = false,
                equation = "(10*3+2)^3"
            };

            //Act
            WeakestCalculationSymbol actualResult = WeakestCalculationSymbol.FromCalculation(equation);

            //Assert
            Assert.AreEqual(expectedResult.Symbol, actualResult.Symbol);
            Assert.AreEqual(expectedResult.index, actualResult.index);
            Assert.AreEqual(expectedResult.IsSingleLeft, actualResult.IsSingleLeft);
            Assert.AreEqual(expectedResult.IsSingleRight, actualResult.IsSingleRight);
            Assert.AreEqual(expectedResult.equation, actualResult.equation);
        }

        [TestMethod]
        public void FromCalculations_Square()
        {
            //Associate
            string equation = "√(3+2)";
            WeakestCalculationSymbol expectedResult = new WeakestCalculationSymbol
            {
                Symbol = "√",
                index = 0,
                IsSingleLeft = false,
                IsSingleRight = true,
                equation = "√(3+2)"
            };

            //Act
            WeakestCalculationSymbol actualResult = WeakestCalculationSymbol.FromCalculation(equation);

            //Assert
            Assert.AreEqual(expectedResult.Symbol, actualResult.Symbol);
            Assert.AreEqual(expectedResult.index, actualResult.index);
            Assert.AreEqual(expectedResult.IsSingleLeft, actualResult.IsSingleLeft);
            Assert.AreEqual(expectedResult.IsSingleRight, actualResult.IsSingleRight);
            Assert.AreEqual(expectedResult.equation, actualResult.equation);
        }

        [TestMethod]
        public void FromCalculations_Factorial()
        {
            //Associate
            string equation = "(1+2+3)!";
            WeakestCalculationSymbol expectedResult = new WeakestCalculationSymbol
            {
                Symbol = "!",
                index = 7,
                IsSingleLeft = true,
                IsSingleRight = false,
                equation = "(1+2+3)!"
            };

            //Act
            WeakestCalculationSymbol actualResult = WeakestCalculationSymbol.FromCalculation(equation);

            //Assert
            Assert.AreEqual(expectedResult.Symbol, actualResult.Symbol);
            Assert.AreEqual(expectedResult.index, actualResult.index);
            Assert.AreEqual(expectedResult.IsSingleLeft, actualResult.IsSingleLeft);
            Assert.AreEqual(expectedResult.IsSingleRight, actualResult.IsSingleRight);
            Assert.AreEqual(expectedResult.equation, actualResult.equation);
        }

        [TestMethod]
        public void FromCalculations_Brackets()
        {
            //Associate
            string equation = "((5+3)+(5+3))";
            WeakestCalculationSymbol expectedResult = new WeakestCalculationSymbol
            {
                Symbol = "+",
                index = 7,
                IsSingleLeft = false,
                IsSingleRight = false,
                equation = "(5+3)+5+3"
            };

            //Act
            WeakestCalculationSymbol actualResult = WeakestCalculationSymbol.FromCalculation(equation);

            //Assert
            Assert.AreEqual(expectedResult.Symbol, actualResult.Symbol);
            Assert.AreEqual(expectedResult.index, actualResult.index);
            Assert.AreEqual(expectedResult.IsSingleLeft, actualResult.IsSingleLeft);
            Assert.AreEqual(expectedResult.IsSingleRight, actualResult.IsSingleRight);
            Assert.AreEqual(expectedResult.equation, actualResult.equation);
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
