namespace B321_Final_APP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLogin = new Panel();
            btnNext_PG1 = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblLogin_LoginPG = new Label();
            pnlModelSelection = new Panel();
            pnlOptions = new Panel();
            pnlSummary = new Panel();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(btnNext_PG1);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Controls.Add(lblLogin_LoginPG);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(1282, 713);
            pnlLogin.TabIndex = 0;
            pnlLogin.Paint += pnlLogin_Paint;
            // 
            // btnNext_PG1
            // 
            btnNext_PG1.Location = new Point(766, 550);
            btnNext_PG1.Name = "btnNext_PG1";
            btnNext_PG1.Size = new Size(175, 75);
            btnNext_PG1.TabIndex = 5;
            btnNext_PG1.Text = "NEXT";
            btnNext_PG1.UseVisualStyleBackColor = true;
            btnNext_PG1.Click += btnNext_PG1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(341, 430);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(600, 38);
            txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(566, 375);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(150, 41);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(341, 276);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(600, 38);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(562, 221);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(158, 41);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblLogin_LoginPG
            // 
            lblLogin_LoginPG.AutoSize = true;
            lblLogin_LoginPG.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin_LoginPG.Location = new Point(194, 50);
            lblLogin_LoginPG.Name = "lblLogin_LoginPG";
            lblLogin_LoginPG.Size = new Size(895, 106);
            lblLogin_LoginPG.TabIndex = 0;
            lblLogin_LoginPG.Text = "Harley Davidson Login";
            lblLogin_LoginPG.TextAlign = ContentAlignment.MiddleCenter;
            lblLogin_LoginPG.Click += lblLogin_LoginPG_Click;
            // 
            // pnlModelSelection
            // 
            pnlModelSelection.Dock = DockStyle.Fill;
            pnlModelSelection.Location = new Point(0, 0);
            pnlModelSelection.Name = "pnlModelSelection";
            pnlModelSelection.Size = new Size(1282, 713);
            pnlModelSelection.TabIndex = 1;
            // 
            // pnlOptions
            // 
            pnlOptions.Dock = DockStyle.Fill;
            pnlOptions.Location = new Point(0, 0);
            pnlOptions.Name = "pnlOptions";
            pnlOptions.Size = new Size(1282, 713);
            pnlOptions.TabIndex = 2;
            // 
            // pnlSummary
            // 
            pnlSummary.Dock = DockStyle.Fill;
            pnlSummary.Location = new Point(0, 0);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(1282, 713);
            pnlSummary.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 713);
            Controls.Add(pnlModelSelection);
            Controls.Add(pnlSummary);
            Controls.Add(pnlOptions);
            Controls.Add(pnlLogin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Panel pnlModelSelection;
        private Panel pnlOptions;
        private Panel pnlSummary;
        private Label lblLogin_LoginPG;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnNext_PG1;
    }
}
