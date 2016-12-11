//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project    :		Project 3 - Infix to Postfix Converter
//	File Name  :		Operator.cs
//	Description:		Class representing one of the operators +-*/()=
//	Course     :		CSCI 2210-201 - Data Structures
//	Author     :		Casey Edwards, zcee10@etsu.edu
//	Created    :		Thursday, October 27, 2016
//	Copyright  :		Casey Edwards, 2016
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace InfixPostfixConverterProject
{
    /// <summary>
    /// This class acts as objects representing mathematical operators and their precedences.
    /// </summary>
    class Operator
    {
        #region Properties
        public string Op { get; set; } // The operator
        public int Precedence { get; set; } // The precedence
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// Sets the operator to the equals "=" symbol.
        /// </summary>
        public Operator()
        {
            Op = "=";
            Precedence = 3;
        }

        /// <summary>
        /// Parameterized Constructor
        /// Sets the operator to the passed argument, and then sets the precedence accordingly.
        /// </summary>
        /// <param name="op">The operator.</param>
        /// <exception cref="ArgumentException">Invalid operator.</exception>
        public Operator(string op)
        {
            Op = op;

            if (Op == "(" || Op == ")")
                Precedence = 0;
            else if (Op == "*" || Op == "/")
                Precedence = 1;
            else if (Op == "+" || Op == "-")
                Precedence = 2;
            else if (Op == "=")
                Precedence = 3;
            else
                throw new ArgumentException("Invalid operator.");
        }
        #endregion

        #region Operator Overloads
        /// <summary>
        /// Implements the operator &gt;.
        /// </summary>
        /// <param name="lhs">The left hand argument.</param>
        /// <param name="rhs">The right hand argument.</param>
        /// <returns>
        /// The boolean precedence result.
        /// </returns>
        static public bool operator > (Operator lhs, Operator rhs)
        {
            return lhs.Precedence > rhs.Precedence;
        }

        /// <summary>
        /// Implements the operator &lt;.
        /// </summary>
        /// <param name="lhs">The left hand argument.</param>
        /// <param name="rhs">The right hand argument.</param>
        /// <returns>
        /// The boolean precedence result.
        /// </returns>
        static public bool operator < (Operator lhs, Operator rhs)
        {
            return lhs.Precedence < rhs.Precedence;
        }
        #endregion
    }
}
