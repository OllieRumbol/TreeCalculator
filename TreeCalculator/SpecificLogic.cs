using System;
using System.Collections.Generic;
using System.Text;

namespace TreeCalculator
{
    public class SpecificLogic
    {
        public static Tree EquationToTree(string equation)
        {
            int number;
            if (int.TryParse(equation, out number))
            {
                return new Tree(number.ToString());
            }

            //There are two different types of equations
            //1. Two numbers and a symbol, for example 
            //  a. 5+6 
            //  b. 77/11
            //  c. Note the more complex equation can be reduced to this 
            //      d. 5+3*4 = 5+12
            //2. One symbol and one number 
            //  a. 10!
            //  b. √100
            //  c. Note that there are two variants, symbol on the left or right
            //The below code deals with building trees from equations in these different formats
            //And then brackets just make everything worse
            //Weakness is used to follow BIDMAS so what calculation bind the least.

            WeakestCalculationSymbol weakestCalculationSymbol = WeakestCalculationSymbol.fromCalculation(equation);
            equation = weakestCalculationSymbol.equation;

            Tree workingTree = new Tree(weakestCalculationSymbol.Symbol);

            if (weakestCalculationSymbol.IsSingleRight)
            {
                string right = equation.Substring(weakestCalculationSymbol.index + 1);

                Tree.JoinRight(workingTree, EquationToTree(right));
            }
            else if (weakestCalculationSymbol.IsSingleLeft)
            {
                string left = equation.Substring(0, weakestCalculationSymbol.index);

                Tree.JoinLeft(workingTree, EquationToTree(left));
            }
            else
            {
                string left = equation.Substring(0, weakestCalculationSymbol.index);
                string right = equation.Substring(weakestCalculationSymbol.index + 1);

                Tree.JoinLeft(workingTree, EquationToTree(left));
                Tree.JoinRight(workingTree, EquationToTree(right));
            }


            return workingTree;
        }

        public static int TreeToInt(Tree tree)
        {
            if (tree.Left == null && tree.Right == null)
            {
                return int.Parse(tree.Node);
            }

            if (tree.Node == "+")
            {
                return TreeToInt(tree.Left) + TreeToInt(tree.Right);
            }
            else if (tree.Node == "-")
            {
                return TreeToInt(tree.Left) - TreeToInt(tree.Right);
            }
            else if (tree.Node == "*")
            {
                return TreeToInt(tree.Left) * TreeToInt(tree.Right);
            }
            else if (tree.Node == "/")
            {
                return TreeToInt(tree.Left) / TreeToInt(tree.Right);
            }
            else if (tree.Node == "^")
            {
                return (int)Math.Pow(TreeToInt(tree.Left), TreeToInt(tree.Right));
            }
            else if(tree.Node == "√")
            {
                return (int)Math.Sqrt(TreeToInt(tree.Right)); 
            }
            else if (tree.Node == "!")
            {
                int number = TreeToInt(tree.Left);
                int result = 1;
                while (number != 1)
                {
                    result = result * number;
                    number = number - 1;
                }
                return result;
            }

            throw new Exception("Invalid equation");
        }
    }
}
