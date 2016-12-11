//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project    :		Project 3 - Infix to Postfix Converter
//	File Name  :		SplashScreen.cs
//	Description:		Splash screen form for the program. Shows title, department graphic, and version number.
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
    /// The splash screen.
    /// Shows the Department of Computing logo, program title, and version number.
    /// Has no border and automatically closes after 3 seconds.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SplashScreen : Form
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="SplashScreen"/> class.
        /// Sets the information based on the Assembly.cs information.
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
            lblTitleText.Text = Application.ProductName;
            lblVersion.Text = "Version: " + Application.ProductVersion;
            Show();
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Handles the Tick event of the tmrSplashTimer control.
        /// Closes the window after one tick.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tmrSplashTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
