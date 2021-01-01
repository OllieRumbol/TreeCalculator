using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeCalculator
{
    public class BracketsHelper
    {

        //6-3 = false
        //(6-3) = true
        public static bool IsSymbolSurroundedWithBrackets(string equation, int indexOfSymbol)
        {
            int openBracketCounter = 0;
            int closeBracketCounter = 0;

            for (int i = 0; i < indexOfSymbol; i++)
            {
                char character = equation[i];
                if (character == '(')
                {
                    openBracketCounter++;
                }
                else if(character == ')')
                {
                    closeBracketCounter++;
                }
            }

            return openBracketCounter > closeBracketCounter;
        }

        public static string RemoveMostInnerBracketsFromEquation(string equation)
        {
            List<PairOfBrackets> indexesOfBrackets = new List<PairOfBrackets>();

            for (int i = 0; i < equation.Length; i++)
            {
                char character = equation[i];
                if (character == '(')
                {
                    indexesOfBrackets.Add(new PairOfBrackets(i));
                }
                else if(character == ')')
                {
                    for (int j = indexesOfBrackets.Count-1; j >= 0; j--)
                    {
                        if(indexesOfBrackets[j].CloseBracket == -1)
                        {
                            indexesOfBrackets[j].CloseBracket = i;
                            break;
                        }
                    }
                }
            }

            if(indexesOfBrackets.Count == 0)
            {
                return equation;
            }

            //There is no need for the whole equation to be wrapped in brackets
            if (indexesOfBrackets.First().OpenBracket == 0 && indexesOfBrackets.First().CloseBracket == equation.Length-1)
            {
                equation = equation.Remove(equation.Length - 1, 1);
                equation = equation.Remove(0, 1);
                indexesOfBrackets.RemoveAt(0);
                //Adjust paits
                foreach(PairOfBrackets pair in indexesOfBrackets)
                {
                    pair.OpenBracket = pair.OpenBracket - 1;
                    pair.CloseBracket = pair.CloseBracket - 1;
                }
            }

            if (indexesOfBrackets.Count == 0)
            {
                return equation;
            }

            PairOfBrackets mostInner = indexesOfBrackets.Last();

            equation = equation.Remove(mostInner.CloseBracket, 1);
            equation = equation.Remove(mostInner.OpenBracket, 1);

            return equation;

        }
    }

    public class PairOfBrackets
    {
        public int OpenBracket { get; set; }

        public int CloseBracket { get; set; }

        public PairOfBrackets(int openBracket)
        {
            this.OpenBracket = openBracket;
            CloseBracket = -1;
        }
    }
}
