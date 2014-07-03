using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RPG.RollDice
{
    public static class DiceParser
    {
        private static Random randomGenerator = new Random(); 
        //public int Roll2(string d20)
        //{
        //    string[] components = d20.Split('d');

        //    int numDice = Int32.Parse(components[0]);
        //    int numSides = Int32.Parse(components[1]);
        //    int result = new Dice(numDice, numSides).Roll();

        //    return result;
        //}
    


        
        ///
        /// Pass a die roll string in any standard d20-type format, including 
        /// parenthetical rolls, and it will output a string breaking down each 
        /// roll as well as summing the total. This works very nicely. The code was 
        /// hacked from java code from Malar's RPG Dice Version 0.9 By Simon Cederqvist 
        /// (simon.cederqvist(INSERT AT HERE) gmail.com). 13.March.2007 
        /// http://users.tkk.fi/~scederqv/Dice/ 
        /// His same license still applies to this code. But if you figure out how to 
        /// make a million dollars off this code, then you're smarter than me and 
        /// you deserve to keep it. On the other hand, share and share alike. 
        ///
        /// This is a standard d20 die roll string, parenthesis 
        /// are allowed. Example Input: (2d8+9)+(3d6+1)-10 
        /// A string breaking down and summing the roll. Example Output: 
        /// (2d8+9)+(3d6+1)-10 = 7+4+9+5+1+2+1-10 = 20+9-10 = 19 

        public static int Roll(string diceString)
        {
            StringBuilder finalResultBuilder = new StringBuilder();
            string tempString = "";
            int intermediateTotal = 0;
            ArrayList sums = new ArrayList();
            ArrayList items = new ArrayList();
            ArrayList dice = new ArrayList();
            int totals = 0;
            bool collate = false;
            bool positive = true;
            string validChars = "1234567890d";
            char[] diceCharArray = diceString.ToLower().ToCharArray();
            string op = "+";

            #region ParseString
            for (int i = 0; i < diceString.Length; i++)
            {
                switch (diceCharArray[i])
                {
                    #region Add
                    case '+':
                        {
                            if (tempString.Length < 1)
                            {
                                finalResultBuilder.Append("+");
                                break;
                            }

                            int result =  calcSubStringRoll(tempString);
                            if (!collate && finalResultBuilder.Length>0)
                            {
                                finalResultBuilder.Append("+");
                                finalResultBuilder.Append(result.ToString());                                
                            }
                            else
                            {                                
                                finalResultBuilder.Append(result.ToString());
                                finalResultBuilder.Append("+");
                            }
                            tempString = "";
                            break;
                        }
                    #endregion
                    #region Subtract
                    case '-':
                        {
                            if (tempString.Length < 1)
                            {
                                finalResultBuilder.Append("-");
                                break;
                            }

                            int result = calcSubStringRoll(tempString);
                            if (!collate && finalResultBuilder.Length > 0)
                            {
                                finalResultBuilder.Append("-");
                                finalResultBuilder.Append(result.ToString());
                            }
                            else
                            {
                                finalResultBuilder.Append(result.ToString());
                                finalResultBuilder.Append("-");
                            }                                                   
                            tempString = "";
                            break;
                        }
                    #endregion
                    #region Multiply
                    case '*':
                        {
                            if (tempString.Length < 1)
                            {
                                finalResultBuilder.Append("*");
                                break;
                            }
                            int result = calcSubStringRoll(tempString);

                            if (!collate && finalResultBuilder.Length > 0)
                            {
                                finalResultBuilder.Append("*");
                                finalResultBuilder.Append(result.ToString());
                            }
                            else
                            {
                                finalResultBuilder.Append(result.ToString());
                                finalResultBuilder.Append("*");
                            }
                            tempString = "";
                            break;
                        }
                    #endregion
                    #region (
                    case '(':
                        collate = true;
                        finalResultBuilder.Append("(");
                        break;
                    #endregion
                    #region )
                    case ')':
                        collate = false;
                        int res = calcSubStringRoll(tempString);
                        finalResultBuilder.Append(res.ToString());
                        finalResultBuilder.Append(")");
                        tempString = "";
                        break;
                    #endregion
                    #region Default
                    default:
                        {
                            if (validChars.Contains("" + diceCharArray[i]))
                                tempString += diceCharArray[i]; break;
                        }
                    #endregion
                }
            }

            // And once more for the remaining text 
            if (tempString.Length > 0)
            {
                int res2 = calcSubStringRoll(tempString);
                finalResultBuilder.Append(res2.ToString());
            }
            #endregion

            totals = Calculate(finalResultBuilder.ToString());

            if (totals>0)
                return totals > 0 ? totals : 1;
            else
                return totals < 0 ? totals : 1;
        }

        private static int Calculate(string diceString)
        {
            int result;
            string convertedString;
            convertedString = diceString;

            convertedString = ProcessParantheses(convertedString);
            convertedString = ProcessMultDiv(convertedString);
            convertedString = ProcessAddSub(convertedString);

            result = Convert.ToInt32(convertedString);
            return result;
        }

        private static string ProcessParantheses(string math)
        {
            string convertedString;
            convertedString = math;

            while (convertedString.IndexOf('(') > -1)
            {
                int startIndex = convertedString.IndexOf('(');
                int endIndex = convertedString.IndexOf(')');

                string newString = convertedString.Substring(startIndex + 1, endIndex - 1);
                int subValue = Calculate(newString);
                convertedString = subValue.ToString() + convertedString.Substring(endIndex + 1);
            }
            return convertedString;
        }

        private static string ProcessMultDiv(string math)
        {
            string convertedString;
            convertedString = math;
        
            while (convertedString.IndexOf('*') > -1 || convertedString.IndexOf('/') > -1)
            {
                int countOps = convertedString.Count(c => c == '*') + convertedString.Count(c => c == '/');
                int multStartIndex = convertedString.IndexOf('*');
                int divStartIndex = convertedString.IndexOf('/');
                int index;

                if (multStartIndex > -1 && divStartIndex > -1)
                    index = multStartIndex < divStartIndex ? multStartIndex : divStartIndex;
                else if (multStartIndex > -1)
                    index = multStartIndex;
                else
                    index = divStartIndex;
                
                if (countOps > 1)
                {                    
                    int startIndex = IndexOfPriorOperator(convertedString.Substring(0, index - 1));
                    int endIndex = IndexOfNextOperator(convertedString.Substring(index + 1));
                    if (endIndex == -1)
                        endIndex = convertedString.Length;

                    string newString = convertedString.Substring(startIndex + 1, endIndex);
                    int subValue = Calculate(newString);
                    convertedString = subValue.ToString() + convertedString.Substring(endIndex + 1);
                }
                else
                {
                    int res;
                    string sval1 = convertedString.Substring(0, index);
                    string sval2 = convertedString.Substring(index + 1);
                    
                    int val1 = Convert.ToInt32(sval1);
                    int val2 = Convert.ToInt32(sval2);
                    if (index == multStartIndex)
                        res = val1 * val2;
                    else
                        res = val1 / val2;
                    convertedString = res.ToString();
                }
            }
            return convertedString;
        }

        private static string ProcessAddSub(string math)
        {
            string convertedString;
            convertedString = math;

            while (convertedString.IndexOf('+') > -1 || convertedString.IndexOf('-') > -1)
            {
                int countOps = convertedString.Count(c => c == '+') + convertedString.Count(c => c == '-');
                int multStartIndex = convertedString.IndexOf('+');
                int divStartIndex = convertedString.IndexOf('-');
                int index;

                if (multStartIndex > -1 && divStartIndex > -1)
                    index = multStartIndex < divStartIndex ? multStartIndex : divStartIndex;
                else if (multStartIndex > -1)
                    index = multStartIndex;
                else
                    index = divStartIndex;

                if (countOps > 1)
                {
                    int startIndex = IndexOfPriorOperator(convertedString.Substring(0, index - 1));
                    int endIndex = IndexOfNextOperator(convertedString.Substring(index + 1));
                    if (endIndex == -1)
                        endIndex = convertedString.Length;

                    string newString = convertedString.Substring(startIndex + 1, endIndex);
                    int subValue = Calculate(newString);
                    convertedString = subValue.ToString() + convertedString.Substring(endIndex + 1);
                }
                else
                {
                    int res;
                    string sval1 = convertedString.Substring(0, index);
                    string sval2 = convertedString.Substring(index + 1);

                    sval1 = sval1.Length > 0 ? sval1 : "0";
                    sval2 = sval2.Length > 0 ? sval2 : "0";

                    int val1 = Convert.ToInt32(sval1);
                    int val2 = Convert.ToInt32(sval2);
                    if (index == multStartIndex)
                        res = val1 + val2;
                    else
                        res = val1 - val2;
                    convertedString = res.ToString();
                }
            }
            return convertedString;
        }

        private static int IndexOfPriorOperator(string s)
        {
            int result;

            result = s.LastIndexOfAny(new char[4]{'*','/','+','-'});

            return result;
        }

        private static int IndexOfNextOperator(string s)
        {
            int result;

            result = s.IndexOf('*');
            result = s.IndexOf('/') < result && s.IndexOf('/') > -1 ? s.IndexOf('/') : result;
            result = s.IndexOf('+') < result && s.IndexOf('+') > -1 ? s.IndexOf('+') : result;
            result = s.IndexOf('-') < result && s.IndexOf('-') > -1 ? s.IndexOf('-') : result;

            return result;
        }

        ///
        /// Rolls the specified number of die each with the specified number of 
        /// sides and returns the numeric result as a string. I had to introduce a 
        /// call to Thread.Sleep() so that the random num gen would seed differently on 
        /// each iteration. 
        ///
        /// The number of die to roll. 
        /// The number of faces on each dice rolled. 
        /// 
        /// A string containing the result of the roll. 
        ///
        /// This function merely breaks down the *basic* die roll string 
        /// into the requsite integers. It is used by the above Roll(string) 
        /// method. 
        ///
        /// A simple die roll string, such as 3d6. Nothing more. 
        /// Returns an ArrayList of int's containing the various die 
        /// rolls as passed in as a parameter. 
        public static int calcSubStringRoll(string s)
        {
            int x, d;
            int roll;
            if (s.Contains("d"))
            {
                x = Convert.ToInt32(s.Split('d')[0]);
                d = Convert.ToInt32(s.Split('d')[1]);
                // I loop here so that each roll is added to the ArrayList, and 
                // therefore works properly with the code I hacked from java above. 
                //for (int i = 0; i < x; i++)
                    //dice.Add(Dice2.Roll(1, d, 0));
                roll = new Dice(x, d).Roll();
            }
            else
                roll = Convert.ToInt32(s);
            return roll;
        }
    }
}
