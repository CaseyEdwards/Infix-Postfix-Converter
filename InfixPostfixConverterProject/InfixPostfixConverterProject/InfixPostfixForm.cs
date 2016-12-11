//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project    :		Project 3 - Infix to Postfix Converter
//	File Name  :		InfixPostfixForm.cs
//	Description:		Main window of the InfixToPostfixConverter program.
//	Course     :		CSCI 2210-201 - Data Structures
//	Author     :		Casey Edwards, zcee10@etsu.edu
//	Created    :		Thursday, October 27, 2016
//	Copyright  :		Casey Edwards, 2016
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InfixPostfixConverterProject
{
    /// <summary>
    /// Main window of the program.
    /// Contains a text box for user input, a read-only text box for output, a list box of
    /// expressions loaded from a file, as well as a menu strip with relevant operations.
    /// Allows tabbing between components in order as well as alt commands.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class InfixPostfixForm : Form
    {
        #region Properties
        private PostFix postFix; // Reference to the postfix converter.
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="InfixPostfixForm"/> class.
        /// </summary>
        public InfixPostfixForm()
        {
            InitializeComponent();
            this.Text = Application.ProductName;
            Show();
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Loads a list of expressions from a file chosen by the user via an OpenFileDialog.
        /// Once loaded, gives the list of expressions to the ListBox for display to the user.
        /// </summary>
        private void LoadFromFile()
        {
            StreamReader rdr = null; // File reader
            List<String> ExpressionList = new List<String>(); // List of expressions from the file.
            OpenFileDialog dlg = new OpenFileDialog(); // Open File Dialog

            // Adjust dialog settings
            dlg.Filter = "Text Files|*.txt;*.text|All Files|*.*";
            dlg.InitialDirectory = Application.StartupPath + @"..\..\SaveData";
            dlg.Title = "Select a file of expressions to load";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // User selected a file, attempt to load data.
                try
                {
                    rdr = new StreamReader(dlg.FileName);
                    while (rdr.Peek() != -1)
                    {
                        ExpressionList.Add(rdr.ReadLine());
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(this, "An error occurred while reading the file:\n" 
                        + ex.Message, "Error");
                }
                finally
                {
                    if (rdr != null)
                        rdr.Close();
                }
            }
            
            // Give the contents of the file to the list box to display, then let it grab focus.
            if (ExpressionList.Count > 0)
            {
                foreach (string expression in ExpressionList)
                    lbxExpressions.Items.Add(expression);
                lbxExpressions.Focus();
            }
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Handles the Click event of the btnExit control.
        /// Exits the program.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the mnuExitItem control.
        /// Exits the program.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mnuExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnClear control.
        /// Empties out the text box fields, and gives focus to the infix box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInfix.Clear();
            txtPostfix.Clear();
            txtInfix.Focus();
        }

        /// <summary>
        /// Handles the Click event of the btnGenerate control.
        /// Creates a new postfix expression and displays the result in the postfix text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            postFix = new PostFix(txtInfix.Text);
            txtPostfix.Text = postFix.PostfixExpression;
        }

        /// <summary>
        /// Handles the Click event of the mnuLoadItem control.
        /// Launches the method for loading data from a file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mnuLoadItem_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the lbxExpressions control.
        /// Sets the infix and postfix text boxes to reflect the newly selected expression.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lbxExpressions_SelectedIndexChanged(object sender, EventArgs e)
        {
            postFix = new PostFix(lbxExpressions.Text);
            txtInfix.Text = postFix.InfixExpression;
            txtPostfix.Text = postFix.PostfixExpression;

        }

        /// <summary>
        /// Handles the Click event of the mnuAboutItem control.
        /// Launches the AboutBox form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mnuAboutItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
        #endregion
    }
}
