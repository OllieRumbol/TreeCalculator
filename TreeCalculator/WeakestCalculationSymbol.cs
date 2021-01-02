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

        public string equation  { get; set; }

        public static WeakestCalculationSymbol FromCalculation(string equation)
        {
            // \((\N+)\)
            for (int i = equation.Length-1; i >= 0; i--)
            {
                string value = equation[i].ToString();
                if (value == "-")
                {
                    if (BracketsHelper.IsSymbolSurroundedWithBrackets(equation, i) == false)
                    {
                        return new WeakestCalculationSymbol
                        {
                            Symbol = value,
                            index = i,
                            IsSingleLeft = false,
                            IsSingleRight = false,
                            equation = equation
                        };
                    }

                }
            }

            for (int i = equation.Length - 1; i >= 0; i--)
            {
                string value = equation[i].ToString();
                if (value == "+")
                {
                    if (BracketsHelper.IsSymbolSurroundedWithBrackets(equation, i) == false)
                    {
                        return new WeakestCalculationSymbol
                        {
                            Symbol = value,
                            index = i,
                            IsSingleLeft = false,
                            IsSingleRight = false,
                            equation = equation
                        };
                    }
                }
            }

            for (int i = equation.Length - 1; i >= 0; i--)
            {
                string value = equation[i].ToString();
                if (value == "*")
                {
                    if (BracketsHelper.IsSymbolSurroundedWithBrackets(equation, i) == false)
                    {
                        return new WeakestCalculationSymbol
                        {
                            Symbol = value,
                            index = i,
                            IsSingleLeft = false,
                            IsSingleRight = false,
                            equation = equation
                        };
                    }
                }
            }

            for (int i = equation.Length - 1; i >= 0; i--)
            {
                string value = equation[i].ToString();
                if (value == "/")
                {
                    if (BracketsHelper.IsSymbolSurroundedWithBrackets(equation, i) == false)
                    {
                        return new WeakestCalculationSymbol
                        {
                            Symbol = value,
                            index = i,
                            IsSingleLeft = false,
                            IsSingleRight = false,
                            equation = equation
                        };
                    }
                }
            }

            for (int i = equation.Length - 1; i >= 0; i--)
            {
                string value = equation[i].ToString();
                if (value == "^")
                {
                    if (BracketsHelper.IsSymbolSurroundedWithBrackets(equation, i) == false)
                    {
                        return new WeakestCalculationSymbol
                        {
                            Symbol = value,
                            index = i,
                            IsSingleLeft = false,
                            IsSingleRight = false,
                            equation = equation
                        };
                    }
                }
            }

            for (int i = equation.Length - 1; i >= 0; i--)
            {
                string value = equation[i].ToString();
                if (value == "√")
                {
                    if (BracketsHelper.IsSymbolSurroundedWithBrackets(equation, i) == false)
                    {
                        return new WeakestCalculationSymbol
                        {
                            Symbol = value,
                            index = i,
                            IsSingleLeft = false,
                            IsSingleRight = true,
                            equation = equation
                        };
                    }
                }
            }

            for (int i = equation.Length - 1; i >= 0; i--)
            {
                string value = equation[i].ToString();
                if (value == "!")
                {
                    if (BracketsHelper.IsSymbolSurroundedWithBrackets(equation, i) == false)
                    {
                        return new WeakestCalculationSymbol
                        {
                            Symbol = value,
                            index = i,
                            IsSingleLeft = true,
                            IsSingleRight = false,
                            equation = equation
                        };
                    }
                }
            }

            for (int i = 0; i < equation.Length; i++)
            {
                string value = equation[i].ToString();
                if (value == "(")
                {
                    equation = BracketsHelper.RemoveMostInnerBracketsFromEquation(equation);
                    return FromCalculation(equation);
                }
            }



            throw new Exception("Invalid symbol");
        }
    }
}
