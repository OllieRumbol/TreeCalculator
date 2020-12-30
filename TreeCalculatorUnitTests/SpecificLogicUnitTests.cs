using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeCalculator;

namespace TreeCalculatorUnitTests
{
    [TestClass]
    public class SpecificLogicUnitTests
    {
        [TestInitialize]
        public void StartUp()
        {

        }

        [TestMethod]
        public void EquationToTree_Addition()
        {
            //Associate
            string equation = "5+3";

            //Act
            Tree expectedTree = SpecificLogic.EquationToTree(equation);

            //Assert
            Assert.AreEqual("+", expectedTree.Node);
            Assert.AreEqual("5", expectedTree.Left.Node);
            Assert.AreEqual("3", expectedTree.Right.Node);
        }

        [TestMethod]
        public void EquationToTree_Test2()
        {
            //Associate
            //Act
            //Assert
        }

        [TestMethod]
        public void EquationToTree_Test3()
        {
            //Associate
            //Act
            //Assert
        }

        [TestMethod]
        public void TreeToInt_Addition()
        {
            //Associate
            Tree tree = new Tree("+");
            tree.Left = new Tree("5");
            tree.Right = new Tree("3");

            //Act
            int answer = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(8, answer);
        }

        [TestMethod]
        public void TreeToInt_Multiplication()
        {
            //Associate
            Tree tree = new Tree("+");
            tree.Left = new Tree("5");
            tree.Right = new Tree("*");
            tree.Right.Left = new Tree("3");
            tree.Right.Right = new Tree("4");

            //Act
            int answer = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(17, answer);
        }

        [TestMethod]
        public void TreeToInt_Division()
        {
            //Associate
            Tree tree = new Tree("*");
            tree.Left = new Tree("/");
            tree.Left.Left = new Tree("10");
            tree.Left.Right = new Tree("2");
            tree.Right = new Tree("5");

            //Act
            int answer = SpecificLogic.TreeToInt(tree);

            //Assert
            Assert.AreEqual(25, answer);
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
