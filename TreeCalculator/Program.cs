using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeCalculator
{
    class Program
    {
        public static Tree EquationToTree(string equation)
        {
            if (equation.Length == 1)
            {
                return new Tree(equation[0].ToString());
            }

            WeakestCalculationSymbol weakestCalculationSymbol = WeakestCalculationSymbol.fromCalculation(equation);

            if (weakestCalculationSymbol.Symbol == string.Empty)
            {
                throw new Exception("Invalid symbol");
            }

            Tree workingTree = new Tree(weakestCalculationSymbol.Symbol);
            string left = equation.Substring(0, weakestCalculationSymbol.index);
            string right = equation.Substring(weakestCalculationSymbol.index + 1);

            Tree.JoinLeft(workingTree, EquationToTree(left));
            Tree.JoinRight(workingTree, EquationToTree(right));

            return workingTree;
        }

        public static int TreeToInt(Tree tree)
        {
            if(tree.Left == null && tree.Right == null)
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

            throw new Exception("Invalid equation");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            string equation = "5+3*4";
            Tree tree = EquationToTree(equation);
            Tree.Print(tree);
            int result = TreeToInt(tree);
            Console.WriteLine($"The answer is {result}");

            Console.WriteLine("End"); 
        }
    }
}
