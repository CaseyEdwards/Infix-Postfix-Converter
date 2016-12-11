//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project    :		Project 3 - Infix to Postfix Converter
//	File Name  :		Driver.cs
//	Description:		Driver class, used to launch the forms of the application.
//	Course     :		CSCI 2210-201 - Data Structures
//	Author     :		Casey Edwards, zcee10@etsu.edu
//	Created    :		Thursday, October 27, 2016
//	Copyright  :		Casey Edwards, 2016
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;

namespace InfixPostfixConverterProject
{
    /// <summary>
    /// Driver class.
    /// Launches the splash screen and the main window.
    /// </summary>
    static class InfixToPostfixDriver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen()); // Splash screen
            Application.Run(new InfixPostfixForm()); // Main window
        }
    }
}
