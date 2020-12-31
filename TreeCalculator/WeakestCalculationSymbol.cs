using System;
using System.Collections.Generic;
using System.Text;

namespace TreeCalculator
{
    public class WeakestCalculationSymbol
    {
        public string Symbol { get; set; }

        public int index { get; set; }

        public bool IsSingleRight { get; set; }

        public bool IsSingleLeft { get; set; }

        public static WeakestCalculationSymbol fromCalculation(string equation)
        {
            // \((\N+)\)
            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i].ToString();
                if (value == "-")
                {
                    return new WeakestCalculationSymbol
                    {
                        Symbol = value,
                        index = i,
                        IsSingleLeft = false,
                        IsSingleRight = false
                    };
                }
            }

            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i].ToString();
                if (value == "+")
                {
                    return new WeakestCalculationSymbol
                    {
                        Symbol = value,
                        index = i,
                        IsSingleLeft = false,
                        IsSingleRight = false
                    };
                }
            }

            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i].ToString();
                if (value == "*")
                {
                    return new WeakestCalculationSymbol
                    {
                        Symbol = value,
                        index = i,
                        IsSingleLeft = false,
                        IsSingleRight = false
                    };
                }
            }

            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i].ToString();
                if (value == "/")
                {
                    return new WeakestCalculationSymbol
                    {
                        Symbol = value,
                        index = i,
                        IsSingleLeft = false,
                        IsSingleRight = false
                    };
                }
            }

            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i].ToString();
                if (value == "^")
                {
                    return new WeakestCalculationSymbol
                    {
                        Symbol = value,
                        index = i,
                        IsSingleLeft = false,
                        IsSingleRight = false
                    };
                }
            }

            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i].ToString();
                if (value == "√")
                {
                    return new WeakestCalculationSymbol
                    {
                        Symbol = value,
                        index = i,
                        IsSingleLeft = false,
                        IsSingleRight = true
                    };
                }
            }

            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i].ToString();
                if (value == "!")
                {
                    return new WeakestCalculationSymbol
                    {
                        Symbol = value,
                        index = i,
                        IsSingleLeft = true,
                        IsSingleRight = false
                    };
                }
            }

            throw new Exception("Invalid symbol");
        }
    }
}
