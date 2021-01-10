using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TreeCalculator;

namespace TreeCalculatorUnitTests
{
    [TestClass]
    public class EquationValidatorUnitTests
    {
        private EquationValidator Validator;

        [TestInitialize]
        public void StartUp()
        {
            Validator = new EquationValidator();
        }

        [TestMethod]
        public void Validate_CheckForInvalidCharacters_True()
        {
            //Associate
            string equation = "5+5";

            //Act
            EquationValidationResults result = Validator.Validate(equation);

            //Assert
            Assert.IsTrue(result.IsValid);
        }

        [TestMethod]
        public void Validate_CheckForInvalidCharacters_False()
        {
            //Associate
            string equation = "5&5";

            //Act
            EquationValidationResults result = Validator.Validate(equation);

            //Assert
            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void Validate_CheckNumberOfBrackets_True()
        {
            //Associate
            string equation = "(6+5)";

            //Act
            EquationValidationResults result = Validator.Validate(equation);

            //Assert
            Assert.IsTrue(result.IsValid);
        }

        [TestMethod]
        public void Validate_CheckNumberOfBrackets_False()
        {
            //Associate
            string equation = "(6+5))";

            //Act
            EquationValidationResults result = Validator.Validate(equation);

            //Assert
            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void Validate_CheckStartAndEndOfEquation_False()
        {
            //Associate
            string equation = "*++";

            //Act
            EquationValidationResults result = Validator.Validate(equation);

            //Assert
            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void Validate_CheckStartAndEndOfEquation_True()
        {
            //Associate
            string equation = "7*8+9";

            //Act
            EquationValidationResults result = Validator.Validate(equation);

            //Assert
            Assert.IsTrue(result.IsValid);
        }

        [TestMethod]
        public void Validate_CheckForDivisionOfZero_False()
        {
            //Associate
            string equation = "6/0";

            //Act
            EquationValidationResults result = Validator.Validate(equation);

            //Assert
            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void Validate_CheckForDivisionOfZero_True()
        {
            //Associate
            string equation = "6/1";

            //Act
            EquationValidationResults result = Validator.Validate(equation);

            //Assert
            Assert.IsTrue(result.IsValid);
        }

        [TestMethod]
        public void Validate_CheckForSquareRootingNegativeNumers_False()
        {
            //Associate
            string equation = "√-100";

            //Act
            EquationValidationResults result = Validator.Validate(equation);

            //Assert
            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void Validate_CheckForSquareRootingNegativeNumers_True()
        {
            //Associate
            string equation = "√(6-3)";

            //Act
            EquationValidationResults result = Validator.Validate(equation);

            //Assert
            Assert.IsTrue(result.IsValid);
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
