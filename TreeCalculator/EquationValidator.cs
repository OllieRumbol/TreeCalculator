using System;
using System.Collections.Generic;
using System.Text;

namespace TreeCalculator
{
    public class EquationValidator
    {
        public EquationValidator()
        {

        }

        public EquationValidationResults Validate(string equation)
        {
            EquationValidationResults invalidCharacters = CheckForInvalidCharacters(equation);
            if (invalidCharacters.IsValid == false)
            {
                return invalidCharacters;
            }

            EquationValidationResults invalidBrackets = CheckNumberOfBrackets(equation);
            if (invalidBrackets.IsValid == false)
            {
                return invalidBrackets;
            }

            EquationValidationResults invalidStartAndEnd = CheckStartAndEndOfEquation(equation);
            if (invalidStartAndEnd.IsValid == false)
            {
                return invalidStartAndEnd;
            }

            EquationValidationResults invalidDivision = CheckForDivisionOfZero(equation);
            if (invalidDivision.IsValid == false)
            {
                return invalidDivision;
            }

            EquationValidationResults invalidSquareRooting = CheckForSquareRootingNegativeNumers(equation);
            if (invalidSquareRooting.IsValid == false)
            {
                return invalidSquareRooting;
            }

            return new EquationValidationResults()
            {
                IsValid = true,
                ErrorMessage = string.Empty
            };
        }

        private EquationValidationResults CheckForInvalidCharacters(string equation)
        {
            List<char> InvalidCharacters = new List<char> { '.', '-', '+', '*', '/', '^', '√', '!', '(', ')' };

            foreach (char character in equation)
            {
                int number;
                if (InvalidCharacters.Contains(character) == false && int.TryParse(character.ToString(), out number) == false)
                {
                    return new EquationValidationResults()
                    {
                        IsValid = false,
                        ErrorMessage = "Invalid character"
                    };
                }
            }

            return new EquationValidationResults()
            {
                IsValid = true,
                ErrorMessage = string.Empty
            };
        }

        private EquationValidationResults CheckNumberOfBrackets(string equation)
        {
            int bracketCounter = 0;

            foreach (char character in equation)
            {
                if (character == '(' || character == ')')
                {
                    bracketCounter++;
                }
            }

            if (bracketCounter % 2 == 0)
            {
                return new EquationValidationResults()
                {
                    IsValid = true,
                    ErrorMessage = string.Empty
                };
            }
            else
            {
                return new EquationValidationResults()
                {
                    IsValid = false,
                    ErrorMessage = "Invalid number of brackets"
                };
            }
        }

        private EquationValidationResults CheckStartAndEndOfEquation(string equation)
        {
            List<char> InvalidStartCharacters = new List<char> { '!', '+', '*', '/', '^', ')', '.' };

            List<char> InvalidEndCharacters = new List<char> { '√', '-', '+', '*', '/', '^', '(', '.', };

            double number;
            if (InvalidStartCharacters.Contains(equation[0]) && Double.TryParse(equation[0].ToString(), out number) == false)
            {
                return new EquationValidationResults()
                {
                    IsValid = false,
                    ErrorMessage = "Invalid starting character of equation."
                };
            }

            if (InvalidEndCharacters.Contains(equation[equation.Length - 1]) && Double.TryParse(equation[equation.Length - 1].ToString(), out number) == false)
            {
                return new EquationValidationResults()
                {
                    IsValid = false,
                    ErrorMessage = "Invalid final character in equation."
                };
            }

            return new EquationValidationResults()
            {
                IsValid = true,
                ErrorMessage = ""
            };
        }

        private EquationValidationResults CheckForDivisionOfZero(string equation)
        {
            for (int i = 0; i < equation.Length - 1; i++)
            {
                char character = equation[i];

                if (character == '/')
                {
                    if (equation[i + 1] == '0')
                    {
                        return new EquationValidationResults()
                        {
                            IsValid = false,
                            ErrorMessage = "Can't divide by 0."
                        };
                    }
                }
            }

            return new EquationValidationResults()
            {
                IsValid = true,
                ErrorMessage = ""
            };
        }

        private EquationValidationResults CheckForSquareRootingNegativeNumers(string equation)
        {
            for (int i = 0; i < equation.Length - 1; i++)
            {
                char character = equation[i];

                if (character == '√')
                {
                    if (equation[i+1] == '-')
                    {
                        return new EquationValidationResults()
                        {
                            IsValid = false,
                            ErrorMessage = "Can't square root a negative number."
                        };
                    }
                }
            }

            return new EquationValidationResults()
            {
                IsValid = true,
                ErrorMessage = ""
            };
        }
    }

    public class EquationValidationResults
    {
        public bool IsValid { get; set; }

        public string ErrorMessage { get; set; }
    }
}
