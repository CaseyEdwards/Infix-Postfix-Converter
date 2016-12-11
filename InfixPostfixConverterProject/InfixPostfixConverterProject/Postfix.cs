//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project    :		Project 3 - Infix to Postfix Converter
//	File Name  :		Postfix.cs
//	Description:		Class that generates a postfix expression from a given infix expression.
//	Course     :		CSCI 2210-201 - Data Structures
//	Author     :		Casey Edwards, zcee10@etsu.edu
//	Created    :		Thursday, October 27, 2016
//	Copyright  :		Casey Edwards, 2016
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace InfixPostfixConverterProject
{
    /// <summary>
    /// The Postfix class.
    /// Allows the setting of an infix expression, and converts the expression to postfix notation.
    /// Invalid expressions set the postfix to an error message.
    /// </summary>
    class PostFix
    {
        #region Properties
        public string InfixExpression { get; set; } // The infix notation expression.
        public string PostfixExpression { get; private set; } // The postfix notation expression.
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFix"/> class.
        /// Uses the default expression "1 + 1" unless another expression is passed as an argument.
        /// </summary>
        /// <param name="input">The infix expression.</param>
        public PostFix(string input = "1 + 1")
        {
            // Set the infix expression as the argument, and then attempt to convert to postfix.
            InfixExpression = input;
            try
            {
                PostfixExpression = Convert();
            }
            catch (Exception ex)
            {
                // If there was an imbalance of parentheses, set an error message.
                if (ex is FormatException || ex is InvalidOperationException)
                    PostfixExpression = "ERROR: Parentheses are mismatched!";
                else
                    throw ex;
            }
        }
        #endregion

        #region Conversion Method
        /// <summary>
        /// Converts the infix expression to a postfix expression.
        /// </summary>
        /// <returns>A string representing a postfix expression.</returns>
        /// <exception cref="FormatException">Mismatched Parentheses</exception>
        private string Convert()
        {
            string PostfixString = String.Empty; // The postfix string.
            Stack<Operator> OperatorStack = new Stack<Operator>(); // The operator stack.
            Stack<char> ParenthesesStack = new Stack<char>(); // Stack for tracking parentheses.
            int index = 0; // Index of the InfixExpression.
            string Operand = String.Empty; // Temp variable for holding operands while parsing.

            // Parse the string one char at a time.
            while (index < InfixExpression.Length)
            {
                if ("+-*/()=".Contains(InfixExpression[index].ToString()))
                {
                    // Operator found.
                    if (Operand.Length != 0)
                    {
                        // Put the parsed operand value on the postfix string and clear the value
                        PostfixString += Operand.Trim() + " ";
                        Operand = String.Empty;
                    }

                    if (InfixExpression[index] == '(') // Open parenthesis found, push onto the stack.
                    {
                        OperatorStack.Push(new Operator("("));
                        ParenthesesStack.Push(InfixExpression[index]); // Track the parentheses matching.
                    }
                    else if (InfixExpression[index] == ')')
                    {
                        // Close parenthesis found, pop operators from the stack onto the postfix string
                        // until an open parenthesis is found.
                        while (OperatorStack.Peek().Op != "(")
                        {
                            PostfixString += OperatorStack.Pop().Op + " ";
                        }
                        OperatorStack.Pop(); // Discard the open parenthesis
                        ParenthesesStack.Pop(); // For parentheses tracking. Throws an exception if mismatched.
                    }
                    else
                    {
                        // Operator other than parentheses was found
                        Operator NewOperator = new Operator(InfixExpression[index].ToString());

                        // Pop operators from the stack until an open parenthesis or an operator of higher precedence is found.
                        while (OperatorStack.Count > 0 && !(NewOperator < OperatorStack.Peek()) && OperatorStack.Peek().Op != "(")
                        {
                            PostfixString += OperatorStack.Pop().Op + " ";
                        }
                        // Put the new operator on the stack
                        OperatorStack.Push(NewOperator);
                    }
                }
                else
                {
                    // Char was not an operator; add it to the operand.
                    Operand += InfixExpression[index];
                }

                // Go to the next index.
                index++;
            }

            // Put the last operand on the string.
            PostfixString += Operand.Trim() + " ";

            // Pop the operators onto the postfix string, discarding parentheses.
            while (OperatorStack.Count != 0)
            {
                if (OperatorStack.Peek().Op != "(" && OperatorStack.Peek().Op != ")")
                    PostfixString += OperatorStack.Pop().Op + " ";
                else
                    OperatorStack.Pop();
            }

            // If the parentheses stack isn't empty, there is a mismatch somewhere.
            if (ParenthesesStack.Count != 0)
                throw new FormatException("Mismatched Parentheses");
            
            // Return the converted string.
            return PostfixString.Trim();
        }
        #endregion
    }
}
