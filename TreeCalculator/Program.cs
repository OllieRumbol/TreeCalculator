using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeCalculator
{
    class Program
    {
        public static Tree EquationToTree(string equation)
        {
            string[] brokenDown = Split(equation);
            Tree tree = EquationToTreeWorker(brokenDown);

            return tree;
        }

        private static string[] Split(string equation)
        {
            string[] result = new string[equation.Length];

            for(int i = 0; i < equation.Length; i++){
                result[i] = equation[i].ToString();
            }

            return result;
        }

        public static Tree EquationToTreeWorker(string[] equation)
        {
            if (equation.Length == 1)
            {
                return new Tree(equation[0]);
            }

            WeakestCalculationSymbol weakestCalculationSymbol = WeakestCalculationSymbol.fromCalculation(equation);

            if (weakestCalculationSymbol.Symbol == string.Empty)
            {
                throw new Exception();
            }

            Tree workingTree = new Tree(weakestCalculationSymbol.Symbol);
            string[] left = equation.Take(weakestCalculationSymbol.index).ToArray();
            string[] right = equation.Skip(weakestCalculationSymbol.index + 1).Take(equation.Length-weakestCalculationSymbol.index+1).ToArray();

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
