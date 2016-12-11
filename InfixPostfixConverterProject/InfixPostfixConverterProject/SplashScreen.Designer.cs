namespace InfixPostfixConverterProject
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.lblETSUImage = new System.Windows.Forms.Label();
            this.lblTitleText = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tmrSplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblETSUImage
            // 
            this.lblETSUImage.AutoSize = true;
            this.lblETSUImage.Image = global::InfixPostfixConverterProject.Properties.Resources.ComputingDepartment;
            this.lblETSUImage.Location = new System.Drawing.Point(0, 0);
            this.lblETSUImage.MinimumSize = new System.Drawing.Size(373, 154);
            this.lblETSUImage.Name = "lblETSUImage";
            this.lblETSUImage.Size = new System.Drawing.Size(373, 154);
            this.lblETSUImage.TabIndex = 0;
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleText.Location = new System.Drawing.Point(-4, 169);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(82, 39);
            this.lblTitleText.TabIndex = 1;
            this.lblTitleText.Text = "Title";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(188, 219);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(71, 20);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version ";
            // 
            // tmrSplashTimer
            // 
            this.tmrSplashTimer.Enabled = true;
            this.tmrSplashTimer.Interval = 3000;
            this.tmrSplashTimer.Tick += new System.EventHandler(this.tmrSplashTimer_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(375, 248);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTitleText);
            this.Controls.Add(this.lblETSUImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.TransparencyKey = System.Drawing.Color.Chartreuse;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblETSUImage;
        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Timer tmrSplashTimer;
    }
}