using System;
using System.Collections.Generic;
using System.Text;

namespace TreeCalculator
{
    public class Tree
    {
        public string Node;
        public Tree Left;
        public Tree Right;

        public Tree(string value)
        {
            this.Node = value;
            this.Left = null;
            this.Right = null;
        }

        public static int Size(Tree tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                int leftDepth = Size(tree.Left);
                int rightDepth = Size(tree.Right);

                if (leftDepth > rightDepth)
                {
                    return (leftDepth + 1);
                }
                    
                return rightDepth + 1;
            }
        }

        public static void Print(Tree tree)
        {
            int size = Size(tree);
            for (int i = 1; i <= size; i++)
            {
                List<string> res = getRow(tree, 1, i, new List<string>());
                foreach (string r in res)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
        }

        public static List<string> getRow(Tree tree, int counter, int goal, List<string> res)
        {
            if (counter == goal)
            {
                res.Add(tree.Node);
            }
            else
            {
                if (tree.Left != null)
                {
                    getRow(tree.Left, counter + 1, goal, res);
                }
                if (tree.Right != null)
                {
                    getRow(tree.Right, counter + 1, goal, res);
                }
            }
            return res;
        }

        internal static Tree JoinLeft(Tree tree, Tree newTree)
        {
            if (tree == null)
            {
                return newTree;
            }

            tree.Left = newTree;
            return tree;
        }

        internal static Tree JoinRight(Tree tree, Tree newTree)
        {
            if (tree == null)
            {
                return newTree;
            }

            tree.Right = newTree;
            return tree;
        }
    }

    public class WeakestCalculationSymbol
    {
        public string Symbol { get; set; }

        public int index { get; set; }

        public static WeakestCalculationSymbol fromCalculation(string[] equation)
        {
            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i];
                if (value == "-")
                {
                    return new WeakestCalculationSymbol
                    {
                        Symbol = value,
                        index = i
                    };
                }
            }

            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i];
                if (value == "+")
                {
                    return new WeakestCalculationSymbol
                    {
                        Symbol = value,
                        index = i
                    };
                }
            }

            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i];
                if (value == "*")
                {
                    return new WeakestCalculationSymbol
                    {
                        Symbol = value,
                        index = i
                    };
                }
            }

            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i];
                if (value == "/")
                {
                    return new WeakestCalculationSymbol
                    {
                        Symbol = value,
                        index = i
                    };
                }
            }

            return new WeakestCalculationSymbol
            {
                Symbol = string.Empty,
                index = 0
            };
        }
    }
}
