namespace B321_Final_APP
{
    partial class frmMain
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
            txtPassword_Login = new TextBox();
            lblPassword_Login = new Label();
            txtUsername_Login = new TextBox();
            lblUsername_Login = new Label();
            lblHarleyDavidson_Login = new Label();
            pnlModelsSelection = new Panel();
            btnNext_Models = new Button();
            pnlGrayGhost_Models = new Panel();
            btnSelectGrayGhost_Models = new Button();
            placeholder1 = new FlowLayoutPanel();
            lblFatboyGrayGhost_Models = new Label();
            lblFatboy_Models = new Label();
            lblBreakout_Models = new Label();
            lblModelSelect = new Label();
            pnlOptions = new Panel();
            pnlSummary = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnBack_Models = new Button();
            pnlGrayGhostOuter_Models = new Panel();
            pnlGreyGhostInner_Models = new Panel();
            btnGrayGhostSelect_Models = new Button();
            placeholder2 = new FlowLayoutPanel();
            pnlBreakoutOuter_Models = new Panel();
            panel5 = new Panel();
            pnlBreakoutInner_Models = new Panel();
            btnBreakoutSelect_Models = new Button();
            placeholder3 = new FlowLayoutPanel();
            button4 = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            pnlFatboyInner_Models = new Panel();
            panel8 = new Panel();
            pnlFatboyOuter_Models = new Panel();
            btnFatboySelect_Models = new Button();
            placeholder = new FlowLayoutPanel();
            button6 = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            btnNext_Login = new Button();
            pnlLogin.SuspendLayout();
            pnlModelsSelection.SuspendLayout();
            pnlGrayGhost_Models.SuspendLayout();
            pnlGrayGhostOuter_Models.SuspendLayout();
            pnlGreyGhostInner_Models.SuspendLayout();
            pnlBreakoutOuter_Models.SuspendLayout();
            panel5.SuspendLayout();
            pnlBreakoutInner_Models.SuspendLayout();
            pnlFatboyInner_Models.SuspendLayout();
            panel8.SuspendLayout();
            pnlFatboyOuter_Models.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.Black;
            pnlLogin.Controls.Add(btnNext_Login);
            pnlLogin.Controls.Add(txtPassword_Login);
            pnlLogin.Controls.Add(lblPassword_Login);
            pnlLogin.Controls.Add(txtUsername_Login);
            pnlLogin.Controls.Add(lblUsername_Login);
            pnlLogin.Controls.Add(lblHarleyDavidson_Login);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(1282, 713);
            pnlLogin.TabIndex = 0;
            pnlLogin.Paint += pnlLogin_Paint;
            // 
            // txtPassword_Login
            // 
            txtPassword_Login.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword_Login.Location = new Point(341, 430);
            txtPassword_Login.Name = "txtPassword_Login";
            txtPassword_Login.Size = new Size(600, 38);
            txtPassword_Login.TabIndex = 4;
            // 
            // lblPassword_Login
            // 
            lblPassword_Login.AutoSize = true;
            lblPassword_Login.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword_Login.ForeColor = Color.FromArgb(255, 128, 0);
            lblPassword_Login.Location = new Point(566, 375);
            lblPassword_Login.Name = "lblPassword_Login";
            lblPassword_Login.Size = new Size(150, 41);
            lblPassword_Login.TabIndex = 3;
            lblPassword_Login.Text = "Password";
            // 
            // txtUsername_Login
            // 
            txtUsername_Login.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername_Login.Location = new Point(341, 276);
            txtUsername_Login.Name = "txtUsername_Login";
            txtUsername_Login.Size = new Size(600, 38);
            txtUsername_Login.TabIndex = 2;
            // 
            // lblUsername_Login
            // 
            lblUsername_Login.AutoSize = true;
            lblUsername_Login.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername_Login.ForeColor = Color.FromArgb(255, 128, 0);
            lblUsername_Login.Location = new Point(562, 221);
            lblUsername_Login.Name = "lblUsername_Login";
            lblUsername_Login.Size = new Size(158, 41);
            lblUsername_Login.TabIndex = 1;
            lblUsername_Login.Text = "Username";
            // 
            // lblHarleyDavidson_Login
            // 
            lblHarleyDavidson_Login.AutoSize = true;
            lblHarleyDavidson_Login.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarleyDavidson_Login.ForeColor = Color.FromArgb(255, 128, 0);
            lblHarleyDavidson_Login.Location = new Point(194, 50);
            lblHarleyDavidson_Login.Name = "lblHarleyDavidson_Login";
            lblHarleyDavidson_Login.Size = new Size(895, 106);
            lblHarleyDavidson_Login.TabIndex = 0;
            lblHarleyDavidson_Login.Text = "Harley Davidson Login";
            lblHarleyDavidson_Login.TextAlign = ContentAlignment.MiddleCenter;
            lblHarleyDavidson_Login.Click += lblLogin_LoginPG_Click;
            // 
            // pnlModelsSelection
            // 
            pnlModelsSelection.BackColor = SystemColors.ActiveCaptionText;
            pnlModelsSelection.Controls.Add(pnlFatboyInner_Models);
            pnlModelsSelection.Controls.Add(pnlBreakoutOuter_Models);
            pnlModelsSelection.Controls.Add(pnlGrayGhostOuter_Models);
            pnlModelsSelection.Controls.Add(btnBack_Models);
            pnlModelsSelection.Controls.Add(btnNext_Models);
            pnlModelsSelection.Controls.Add(lblFatboyGrayGhost_Models);
            pnlModelsSelection.Controls.Add(lblFatboy_Models);
            pnlModelsSelection.Controls.Add(lblBreakout_Models);
            pnlModelsSelection.Controls.Add(lblModelSelect);
            pnlModelsSelection.Dock = DockStyle.Fill;
            pnlModelsSelection.ForeColor = SystemColors.Control;
            pnlModelsSelection.Location = new Point(0, 0);
            pnlModelsSelection.Name = "pnlModelsSelection";
            pnlModelsSelection.Size = new Size(1282, 713);
            pnlModelsSelection.TabIndex = 1;
            // 
            // btnNext_Models
            // 
            btnNext_Models.BackColor = Color.FromArgb(255, 128, 0);
            btnNext_Models.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext_Models.ForeColor = Color.Black;
            btnNext_Models.Location = new Point(988, 620);
            btnNext_Models.Name = "btnNext_Models";
            btnNext_Models.Size = new Size(200, 50);
            btnNext_Models.TabIndex = 4;
            btnNext_Models.Text = "Next: Options";
            btnNext_Models.UseVisualStyleBackColor = false;
            // 
            // pnlGrayGhost_Models
            // 
            pnlGrayGhost_Models.BackColor = Color.FromArgb(50, 50, 50);
            pnlGrayGhost_Models.BorderStyle = BorderStyle.FixedSingle;
            pnlGrayGhost_Models.Controls.Add(pnlGreyGhostInner_Models);
            pnlGrayGhost_Models.Controls.Add(btnSelectGrayGhost_Models);
            pnlGrayGhost_Models.Controls.Add(placeholder1);
            pnlGrayGhost_Models.Location = new Point(3, 3);
            pnlGrayGhost_Models.Name = "pnlGrayGhost_Models";
            pnlGrayGhost_Models.Size = new Size(300, 320);
            pnlGrayGhost_Models.TabIndex = 5;
            // 
            // btnSelectGrayGhost_Models
            // 
            btnSelectGrayGhost_Models.BackColor = Color.FromArgb(255, 128, 0);
            btnSelectGrayGhost_Models.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectGrayGhost_Models.ForeColor = Color.Black;
            btnSelectGrayGhost_Models.Location = new Point(50, 250);
            btnSelectGrayGhost_Models.Name = "btnSelectGrayGhost_Models";
            btnSelectGrayGhost_Models.Size = new Size(200, 50);
            btnSelectGrayGhost_Models.TabIndex = 1;
            btnSelectGrayGhost_Models.Text = "Select";
            btnSelectGrayGhost_Models.UseVisualStyleBackColor = false;
            // 
            // placeholder1
            // 
            placeholder1.BackColor = Color.Gray;
            placeholder1.Location = new Point(25, 20);
            placeholder1.Name = "placeholder1";
            placeholder1.Size = new Size(250, 125);
            placeholder1.TabIndex = 0;
            // 
            // lblFatboyGrayGhost_Models
            // 
            lblFatboyGrayGhost_Models.AutoSize = true;
            lblFatboyGrayGhost_Models.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblFatboyGrayGhost_Models.ForeColor = Color.White;
            lblFatboyGrayGhost_Models.Location = new Point(450, 170);
            lblFatboyGrayGhost_Models.Name = "lblFatboyGrayGhost_Models";
            lblFatboyGrayGhost_Models.Size = new Size(383, 54);
            lblFatboyGrayGhost_Models.TabIndex = 3;
            lblFatboyGrayGhost_Models.Text = "Fatboy: Gray Ghost";
            // 
            // lblFatboy_Models
            // 
            lblFatboy_Models.AutoSize = true;
            lblFatboy_Models.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblFatboy_Models.ForeColor = Color.White;
            lblFatboy_Models.Location = new Point(955, 170);
            lblFatboy_Models.Name = "lblFatboy_Models";
            lblFatboy_Models.Size = new Size(152, 54);
            lblFatboy_Models.TabIndex = 2;
            lblFatboy_Models.Text = "Fatboy";
            // 
            // lblBreakout_Models
            // 
            lblBreakout_Models.AutoSize = true;
            lblBreakout_Models.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBreakout_Models.ForeColor = Color.White;
            lblBreakout_Models.Location = new Point(155, 170);
            lblBreakout_Models.Name = "lblBreakout_Models";
            lblBreakout_Models.Size = new Size(194, 54);
            lblBreakout_Models.TabIndex = 1;
            lblBreakout_Models.Text = "Breakout";
            // 
            // lblModelSelect
            // 
            lblModelSelect.AutoSize = true;
            lblModelSelect.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelSelect.ForeColor = Color.FromArgb(255, 128, 0);
            lblModelSelect.Location = new Point(279, 30);
            lblModelSelect.Name = "lblModelSelect";
            lblModelSelect.Size = new Size(725, 106);
            lblModelSelect.TabIndex = 0;
            lblModelSelect.Text = "Select Your Model";
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
            // btnBack_Models
            // 
            btnBack_Models.BackColor = Color.FromArgb(255, 128, 0);
            btnBack_Models.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack_Models.ForeColor = Color.Black;
            btnBack_Models.Location = new Point(95, 620);
            btnBack_Models.Name = "btnBack_Models";
            btnBack_Models.Size = new Size(200, 50);
            btnBack_Models.TabIndex = 6;
            btnBack_Models.Text = "Back: Login";
            btnBack_Models.UseVisualStyleBackColor = false;
            // 
            // pnlGrayGhostOuter_Models
            // 
            pnlGrayGhostOuter_Models.BackColor = Color.White;
            pnlGrayGhostOuter_Models.Controls.Add(pnlGrayGhost_Models);
            pnlGrayGhostOuter_Models.Location = new Point(492, 246);
            pnlGrayGhostOuter_Models.Name = "pnlGrayGhostOuter_Models";
            pnlGrayGhostOuter_Models.Size = new Size(305, 325);
            pnlGrayGhostOuter_Models.TabIndex = 8;
            // 
            // pnlGreyGhostInner_Models
            // 
            pnlGreyGhostInner_Models.BackColor = Color.FromArgb(50, 50, 50);
            pnlGreyGhostInner_Models.Controls.Add(btnGrayGhostSelect_Models);
            pnlGreyGhostInner_Models.Controls.Add(placeholder2);
            pnlGreyGhostInner_Models.Location = new Point(-1, -1);
            pnlGreyGhostInner_Models.Name = "pnlGreyGhostInner_Models";
            pnlGreyGhostInner_Models.Size = new Size(300, 320);
            pnlGreyGhostInner_Models.TabIndex = 6;
            // 
            // btnGrayGhostSelect_Models
            // 
            btnGrayGhostSelect_Models.BackColor = Color.FromArgb(255, 128, 0);
            btnGrayGhostSelect_Models.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrayGhostSelect_Models.ForeColor = Color.Black;
            btnGrayGhostSelect_Models.Location = new Point(50, 250);
            btnGrayGhostSelect_Models.Name = "btnGrayGhostSelect_Models";
            btnGrayGhostSelect_Models.Size = new Size(200, 50);
            btnGrayGhostSelect_Models.TabIndex = 1;
            btnGrayGhostSelect_Models.Text = "Select";
            btnGrayGhostSelect_Models.UseVisualStyleBackColor = false;
            // 
            // placeholder2
            // 
            placeholder2.BackColor = Color.Gray;
            placeholder2.Location = new Point(25, 20);
            placeholder2.Name = "placeholder2";
            placeholder2.Size = new Size(250, 125);
            placeholder2.TabIndex = 0;
            // 
            // pnlBreakoutOuter_Models
            // 
            pnlBreakoutOuter_Models.BackColor = Color.White;
            pnlBreakoutOuter_Models.Controls.Add(panel5);
            pnlBreakoutOuter_Models.Location = new Point(95, 246);
            pnlBreakoutOuter_Models.Name = "pnlBreakoutOuter_Models";
            pnlBreakoutOuter_Models.Size = new Size(305, 325);
            pnlBreakoutOuter_Models.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 50, 50);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pnlBreakoutInner_Models);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(flowLayoutPanel4);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 320);
            panel5.TabIndex = 5;
            // 
            // pnlBreakoutInner_Models
            // 
            pnlBreakoutInner_Models.BackColor = Color.FromArgb(50, 50, 50);
            pnlBreakoutInner_Models.Controls.Add(btnBreakoutSelect_Models);
            pnlBreakoutInner_Models.Controls.Add(placeholder3);
            pnlBreakoutInner_Models.Location = new Point(-1, -1);
            pnlBreakoutInner_Models.Name = "pnlBreakoutInner_Models";
            pnlBreakoutInner_Models.Size = new Size(300, 320);
            pnlBreakoutInner_Models.TabIndex = 6;
            // 
            // btnBreakoutSelect_Models
            // 
            btnBreakoutSelect_Models.BackColor = Color.FromArgb(255, 128, 0);
            btnBreakoutSelect_Models.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBreakoutSelect_Models.ForeColor = Color.Black;
            btnBreakoutSelect_Models.Location = new Point(50, 250);
            btnBreakoutSelect_Models.Name = "btnBreakoutSelect_Models";
            btnBreakoutSelect_Models.Size = new Size(200, 50);
            btnBreakoutSelect_Models.TabIndex = 1;
            btnBreakoutSelect_Models.Text = "Select";
            btnBreakoutSelect_Models.UseVisualStyleBackColor = false;
            // 
            // placeholder3
            // 
            placeholder3.BackColor = Color.Gray;
            placeholder3.Location = new Point(25, 20);
            placeholder3.Name = "placeholder3";
            placeholder3.Size = new Size(250, 125);
            placeholder3.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(50, 250);
            button4.Name = "button4";
            button4.Size = new Size(200, 50);
            button4.TabIndex = 1;
            button4.Text = "Select";
            button4.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.Gray;
            flowLayoutPanel4.Location = new Point(25, 20);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(250, 125);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // pnlFatboyInner_Models
            // 
            pnlFatboyInner_Models.BackColor = Color.White;
            pnlFatboyInner_Models.Controls.Add(panel8);
            pnlFatboyInner_Models.Location = new Point(883, 246);
            pnlFatboyInner_Models.Name = "pnlFatboyInner_Models";
            pnlFatboyInner_Models.Size = new Size(305, 325);
            pnlFatboyInner_Models.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(50, 50, 50);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(pnlFatboyOuter_Models);
            panel8.Controls.Add(button6);
            panel8.Controls.Add(flowLayoutPanel5);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(300, 320);
            panel8.TabIndex = 5;
            // 
            // pnlFatboyOuter_Models
            // 
            pnlFatboyOuter_Models.BackColor = Color.FromArgb(50, 50, 50);
            pnlFatboyOuter_Models.Controls.Add(btnFatboySelect_Models);
            pnlFatboyOuter_Models.Controls.Add(placeholder);
            pnlFatboyOuter_Models.Location = new Point(-1, -1);
            pnlFatboyOuter_Models.Name = "pnlFatboyOuter_Models";
            pnlFatboyOuter_Models.Size = new Size(300, 320);
            pnlFatboyOuter_Models.TabIndex = 6;
            // 
            // btnFatboySelect_Models
            // 
            btnFatboySelect_Models.BackColor = Color.FromArgb(255, 128, 0);
            btnFatboySelect_Models.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFatboySelect_Models.ForeColor = Color.Black;
            btnFatboySelect_Models.Location = new Point(50, 250);
            btnFatboySelect_Models.Name = "btnFatboySelect_Models";
            btnFatboySelect_Models.Size = new Size(200, 50);
            btnFatboySelect_Models.TabIndex = 1;
            btnFatboySelect_Models.Text = "Select";
            btnFatboySelect_Models.UseVisualStyleBackColor = false;
            // 
            // placeholder
            // 
            placeholder.BackColor = Color.Gray;
            placeholder.Location = new Point(25, 20);
            placeholder.Name = "placeholder";
            placeholder.Size = new Size(250, 125);
            placeholder.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 128, 0);
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(50, 250);
            button6.Name = "button6";
            button6.Size = new Size(200, 50);
            button6.TabIndex = 1;
            button6.Text = "Select";
            button6.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = Color.Gray;
            flowLayoutPanel5.Location = new Point(25, 20);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(250, 125);
            flowLayoutPanel5.TabIndex = 0;
            // 
            // btnNext_Login
            // 
            btnNext_Login.BackColor = Color.FromArgb(255, 128, 0);
            btnNext_Login.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext_Login.ForeColor = Color.Black;
            btnNext_Login.Location = new Point(741, 555);
            btnNext_Login.Name = "btnNext_Login";
            btnNext_Login.Size = new Size(200, 50);
            btnNext_Login.TabIndex = 5;
            btnNext_Login.Text = "Next: Models";
            btnNext_Login.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 713);
            Controls.Add(pnlLogin);
            Controls.Add(pnlModelsSelection);
            Controls.Add(pnlSummary);
            Controls.Add(pnlOptions);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Z & D Harley Davidson";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlModelsSelection.ResumeLayout(false);
            pnlModelsSelection.PerformLayout();
            pnlGrayGhost_Models.ResumeLayout(false);
            pnlGrayGhostOuter_Models.ResumeLayout(false);
            pnlGreyGhostInner_Models.ResumeLayout(false);
            pnlBreakoutOuter_Models.ResumeLayout(false);
            panel5.ResumeLayout(false);
            pnlBreakoutInner_Models.ResumeLayout(false);
            pnlFatboyInner_Models.ResumeLayout(false);
            panel8.ResumeLayout(false);
            pnlFatboyOuter_Models.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Panel pnlModelsSelection;
        private Panel pnlOptions;
        private Panel pnlSummary;
        private Label lblHarleyDavidson_Login;
        private TextBox txtUsername_Login;
        private Label lblUsername_Login;
        private TextBox txtPassword_Login;
        private Label lblPassword_Login;
        private Label lblFatboy_Models;
        private Label lblBreakout_Models;
        private Label lblModelSelect;
        private Label lblFatboyGrayGhost_Models;
        private Panel pnlGrayGhost_Models;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel placeholder1;
        private Button btnSelectGrayGhost_Models;
        private Button btnNext_Models;
        private Button btnBack_Models;
        private Panel pnlBreakoutOuter_Models;
        private Panel panel5;
        private Panel pnlBreakoutInner_Models;
        private Button btnBreakoutSelect_Models;
        private FlowLayoutPanel placeholder3;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel pnlGrayGhostOuter_Models;
        private Panel pnlGreyGhostInner_Models;
        private Button btnGrayGhostSelect_Models;
        private FlowLayoutPanel placeholder2;
        private Panel pnlFatboyInner_Models;
        private Panel panel8;
        private Panel pnlFatboyOuter_Models;
        private Button btnFatboySelect_Models;
        private FlowLayoutPanel placeholder;
        private Button button6;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button btnNext_Login;
    }
}
