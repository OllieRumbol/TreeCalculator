using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TreeCalculator;

namespace TreeCalculatorUnitTests
{
    [TestClass]
    public class TreeUnitTests
    {
        [TestInitialize]
        public void StartUp()
        {

        }

        [TestMethod]
        public void SizeOfTree_Test1()
        {
            //Associate
            Tree tree = new Tree("+");

            //Act
            int size = Tree.Size(tree);

            //Assert
            Assert.AreEqual(1, size);
        }

        [TestMethod]
        public void SizeOfTree_Test2()
        {
            //Associate
            Tree tree = new Tree("+");
            tree.Left = new Tree("5");
            tree.Right = new Tree("*");
            tree.Right.Left = new Tree("3");
            tree.Right.Right = new Tree("4");

            //Act
            int size = Tree.Size(tree);

            //Assert
            Assert.AreEqual(3, size);
        }

        [TestMethod]
        public void getRowInTree_Test1()
        {
            //Associate
            Tree tree = new Tree("+");
            tree.Left = new Tree("5");
            tree.Right = new Tree("*");
            tree.Right.Left = new Tree("3");
            tree.Right.Right = new Tree("4");

            //Act
            List<string> actualResult = Tree.getRow(tree, 1, 3, new List<string>());

            //Assert
            Assert.AreEqual("3", actualResult[0]);
            Assert.AreEqual("4", actualResult[1]);
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
