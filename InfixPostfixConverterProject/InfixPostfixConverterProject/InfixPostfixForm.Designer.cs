namespace InfixPostfixConverterProject
{
    partial class InfixPostfixForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfixPostfixForm));
            this.txtInfix = new System.Windows.Forms.TextBox();
            this.txtPostfix = new System.Windows.Forms.TextBox();
            this.lblInfix = new System.Windows.Forms.Label();
            this.lblPostfix = new System.Windows.Forms.Label();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbxExpressions = new System.Windows.Forms.ListBox();
            this.lblListBoxTitle = new System.Windows.Forms.Label();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInfix
            // 
            this.txtInfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfix.Location = new System.Drawing.Point(182, 326);
            this.txtInfix.Name = "txtInfix";
            this.txtInfix.Size = new System.Drawing.Size(649, 30);
            this.txtInfix.TabIndex = 4;
            // 
            // txtPostfix
            // 
            this.txtPostfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostfix.Location = new System.Drawing.Point(182, 367);
            this.txtPostfix.Name = "txtPostfix";
            this.txtPostfix.ReadOnly = true;
            this.txtPostfix.Size = new System.Drawing.Size(649, 30);
            this.txtPostfix.TabIndex = 9;
            this.txtPostfix.TabStop = false;
            // 
            // lblInfix
            // 
            this.lblInfix.AutoSize = true;
            this.lblInfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfix.Location = new System.Drawing.Point(33, 332);
            this.lblInfix.Name = "lblInfix";
            this.lblInfix.Size = new System.Drawing.Size(143, 24);
            this.lblInfix.TabIndex = 3;
            this.lblInfix.Text = "&Infix Expression";
            // 
            // lblPostfix
            // 
            this.lblPostfix.AutoSize = true;
            this.lblPostfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostfix.Location = new System.Drawing.Point(12, 367);
            this.lblPostfix.Name = "lblPostfix";
            this.lblPostfix.Size = new System.Drawing.Size(164, 24);
            this.lblPostfix.TabIndex = 8;
            this.lblPostfix.Text = "Postfix Expression";
            // 
            // mnuStrip
            // 
            this.mnuStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenuItem,
            this.mnuHelpItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(843, 31);
            this.mnuStrip.TabIndex = 0;
            this.mnuStrip.Text = "mnuStrip";
            // 
            // mnuMenuItem
            // 
            this.mnuMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadItem,
            this.toolStripSeparator1,
            this.mnuExitItem});
            this.mnuMenuItem.Name = "mnuMenuItem";
            this.mnuMenuItem.Size = new System.Drawing.Size(66, 27);
            this.mnuMenuItem.Text = "&Menu";
            // 
            // mnuLoadItem
            // 
            this.mnuLoadItem.Image = global::InfixPostfixConverterProject.Properties.Resources.SaveIcon;
            this.mnuLoadItem.Name = "mnuLoadItem";
            this.mnuLoadItem.Size = new System.Drawing.Size(238, 28);
            this.mnuLoadItem.Text = "&Load Data From File";
            this.mnuLoadItem.Click += new System.EventHandler(this.mnuLoadItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // mnuExitItem
            // 
            this.mnuExitItem.Image = global::InfixPostfixConverterProject.Properties.Resources.ExitIcon;
            this.mnuExitItem.Name = "mnuExitItem";
            this.mnuExitItem.Size = new System.Drawing.Size(238, 28);
            this.mnuExitItem.Text = "&Exit";
            this.mnuExitItem.Click += new System.EventHandler(this.mnuExitItem_Click);
            // 
            // mnuHelpItem
            // 
            this.mnuHelpItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutItem});
            this.mnuHelpItem.Name = "mnuHelpItem";
            this.mnuHelpItem.Size = new System.Drawing.Size(57, 27);
            this.mnuHelpItem.Text = "&Help";
            // 
            // mnuAboutItem
            // 
            this.mnuAboutItem.Image = global::InfixPostfixConverterProject.Properties.Resources.AboutIcon;
            this.mnuAboutItem.Name = "mnuAboutItem";
            this.mnuAboutItem.Size = new System.Drawing.Size(133, 28);
            this.mnuAboutItem.Text = "&About";
            this.mnuAboutItem.Click += new System.EventHandler(this.mnuAboutItem_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(76, 417);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(195, 30);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "&Generate Postfix";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(330, 417);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(195, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(587, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbxExpressions
            // 
            this.lbxExpressions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxExpressions.FormattingEnabled = true;
            this.lbxExpressions.ItemHeight = 18;
            this.lbxExpressions.Location = new System.Drawing.Point(16, 67);
            this.lbxExpressions.Name = "lbxExpressions";
            this.lbxExpressions.Size = new System.Drawing.Size(815, 256);
            this.lbxExpressions.TabIndex = 2;
            this.lbxExpressions.SelectedIndexChanged += new System.EventHandler(this.lbxExpressions_SelectedIndexChanged);
            // 
            // lblListBoxTitle
            // 
            this.lblListBoxTitle.AutoSize = true;
            this.lblListBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListBoxTitle.Location = new System.Drawing.Point(12, 40);
            this.lblListBoxTitle.Name = "lblListBoxTitle";
            this.lblListBoxTitle.Size = new System.Drawing.Size(175, 24);
            this.lblListBoxTitle.TabIndex = 1;
            this.lblListBoxTitle.Text = "Infix Expression &List";
            // 
            // InfixPostfixForm
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(843, 476);
            this.Controls.Add(this.lblListBoxTitle);
            this.Controls.Add(this.lbxExpressions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblPostfix);
            this.Controls.Add(this.lblInfix);
            this.Controls.Add(this.txtPostfix);
            this.Controls.Add(this.txtInfix);
            this.Controls.Add(this.mnuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "InfixPostfixForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfix;
        private System.Windows.Forms.TextBox txtPostfix;
        private System.Windows.Forms.Label lblInfix;
        private System.Windows.Forms.Label lblPostfix;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExitItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutItem;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbxExpressions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblListBoxTitle;
    }
}

