using System;
using System.Collections.Generic;
using System.Text;

namespace TreeCalculator
{
    public class WeakestCalculationSymbol
    {
        public string Symbol { get; set; }

        public int index { get; set; }

        public static WeakestCalculationSymbol fromCalculation(string equation)
        {
            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i].ToString();
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
                string value = equation[i].ToString();
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
                string value = equation[i].ToString();
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
                string value = equation[i].ToString();
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
