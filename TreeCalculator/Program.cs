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
            // TODO: Work with negatives e.g. -5 or -71
            // TODO: Pi

            Console.WriteLine("Start");
            string equation = "5.2+5.2";
            Tree tree = SpecificLogic.EquationToTree(equation);
            Tree.Print(tree);
            double result = SpecificLogic.TreeToInt(tree);
            Console.WriteLine($"The answer is {result}");

            Console.WriteLine("End"); 
        }
    }
}
