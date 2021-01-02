using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Equation validation 
            // TODO: Work with doubles e.g. 2.1 or 4.5
            // TODO: Work with negatives e.g. -5 or -71

            Console.WriteLine("Start");
            string equation = "(6+3)*4";
            Tree tree = SpecificLogic.EquationToTree(equation);
            Tree.Print(tree);
            int result = SpecificLogic.TreeToInt(tree);
            Console.WriteLine($"The answer is {result}");

            Console.WriteLine("End"); 
        }
    }
}
