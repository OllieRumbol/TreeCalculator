using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TreeCalculator;

namespace TreeCalculatorUnitTests
{
    [TestClass]
    public class EndToEndTests
    {
        [TestInitialize]
        public void StartUp()
        {

        }

        [TestMethod]
        public void Addition_Test1()
        {
            //Associate
            string equation = "2+4+6+8";
            double answer = 20;

            //Act
            Tree tree = SpecificLogic.EquationToTree(equation);
            double result = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(answer, result);
        }

        [TestMethod]
        public void Subtraction_Test1()
        {
            //Associate
            string equation = "10-5-2";
            double answer = 3;

            //Act
            Tree tree = SpecificLogic.EquationToTree(equation);
            double result = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(answer, result);
        }

        [TestMethod]
        public void Multiplication_Test1()
        {
            //Associate
            string equation = "8*8*2";
            double answer = 128;

            //Act
            Tree tree = SpecificLogic.EquationToTree(equation);
            double result = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(answer, result);
        }

        [TestMethod]
        public void Division_Test1()
        {
            //Associate
            string equation = "20/5/2";
            double answer = 2;

            //Act
            Tree tree = SpecificLogic.EquationToTree(equation);
            double result = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(answer, result);
        }

        [TestMethod]
        public void Power_Test1()
        {
            //Associate
            string equation = "6^3";
            double answer = 216;

            //Act
            Tree tree = SpecificLogic.EquationToTree(equation);
            double result = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(answer, result);
        }

        [TestMethod]
        public void SquareRoot_Test1()
        {
            //Associate
            string equation = "√64";
            double answer = 8;

            //Act
            Tree tree = SpecificLogic.EquationToTree(equation);
            double result = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(answer, result);
        }

        [TestMethod]
        public void Factorial_Test1()
        {
            //Associate
            string equation = "7!";
            double answer = 5040;

            //Act
            Tree tree = SpecificLogic.EquationToTree(equation);
            double result = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(answer, result);
        }

        [TestMethod]
        public void Brackets_Test1()
        {
            //Associate
            string equation = "(6+3)*4";
            double answer = 36;

            //Act
            Tree tree = SpecificLogic.EquationToTree(equation);
            double result = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(answer, result);
        }
      
        [TestMethod]
        public void Brackets_Test2()
        {
            //Associate
            string equation = "√(102-2)";
            double answer = 10;

            //Act
            Tree tree = SpecificLogic.EquationToTree(equation);
            double result = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(answer, result);
        }

        [TestMethod]
        public void Brackets_Test3()
        {
            //Associate
            string equation = "(2*2+1)!";
            double answer = 120;

            //Act
            Tree tree = SpecificLogic.EquationToTree(equation);
            double result = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(answer, result);
        }

        [TestMethod]
        public void Brackets_Test4()
        {
            //Associate
            string equation = "(10/2*5)+(7-2)";
            double answer = 30;

            //Act
            Tree tree = SpecificLogic.EquationToTree(equation);
            double result = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(answer, result);
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
