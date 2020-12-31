using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            string equation = "5!+5";
            Tree tree = SpecificLogic.EquationToTree(equation);
            Tree.Print(tree);
            int result = SpecificLogic.TreeToInt(tree);
            Console.WriteLine($"The answer is {result}");

            Console.WriteLine("End"); 
        }
    }
}
