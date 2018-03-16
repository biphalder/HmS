namespace HospitalManagementSystem
{
    partial class SignUp
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
            this.buttonBackToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackToLogin
            // 
            this.buttonBackToLogin.BackColor = System.Drawing.Color.Crimson;
            this.buttonBackToLogin.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToLogin.ForeColor = System.Drawing.Color.White;
            this.buttonBackToLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToLogin.Name = "buttonBackToLogin";
            this.buttonBackToLogin.Size = new System.Drawing.Size(91, 23);
            this.buttonBackToLogin.TabIndex = 0;
            this.buttonBackToLogin.Text = "Back To Login";
            this.buttonBackToLogin.UseVisualStyleBackColor = false;
            this.buttonBackToLogin.Click += new System.EventHandler(this.buttonBackToLogin_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 408);
            this.Controls.Add(this.buttonBackToLogin);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToLogin;
    }
}