using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeCalculator
{
    class Program
    {
        public static Tree EquationToTree(string equation)
        {
            return EquationToTreeWorker(equation);
        }

        public static Tree EquationToTreeWorker(string equation)
        {
            if (equation.Length == 1)
            {
                return new Tree(equation[0].ToString());
            }

            WeakestCalculationSymbol weakestCalculationSymbol = WeakestCalculationSymbol.fromCalculation(equation);

            if (weakestCalculationSymbol.Symbol == string.Empty)
            {
                throw new Exception();
            }

            Tree workingTree = new Tree(weakestCalculationSymbol.Symbol);
            string left = equation.Substring(0, weakestCalculationSymbol.index);
            string right = equation.Substring(weakestCalculationSymbol.index + 1);

            Tree.JoinLeft(workingTree, EquationToTreeWorker(left));
            Tree.JoinRight(workingTree, EquationToTreeWorker(right));

            return workingTree;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            string equation = "5+3*4";
            Tree tree = EquationToTree(equation);
            Tree.Print(tree);

            Console.WriteLine("End"); 
        }
    }
}
