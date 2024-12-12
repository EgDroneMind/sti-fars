namespace FARS
{
    partial class frmSignup
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
            btnSignUp = new Button();
            txtBoxPassword = new TextBox();
            lblPassword = new Label();
            lblSignup = new Label();
            txtBoxFName = new TextBox();
            lblFName = new Label();
            txtBoxLName = new TextBox();
            lblLName = new Label();
            txtBoxMName = new TextBox();
            lblMName = new Label();
            lblProgram = new Label();
            cmbBoxProgram = new ComboBox();
            txtBoxStudentNo = new TextBox();
            lblStudentNo = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(280, 275);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(84, 34);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(125, 240);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(239, 29);
            txtBoxPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 243);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password:";
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignup.ForeColor = Color.MediumPurple;
            lblSignup.Location = new Point(12, 15);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(117, 37);
            lblSignup.TabIndex = 7;
            lblSignup.Text = "Sign Up";
            // 
            // txtBoxFName
            // 
            txtBoxFName.Location = new Point(125, 100);
            txtBoxFName.Name = "txtBoxFName";
            txtBoxFName.Size = new Size(239, 29);
            txtBoxFName.TabIndex = 2;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(30, 103);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(89, 21);
            lblFName.TabIndex = 17;
            lblFName.Text = "First Name:";
            // 
            // txtBoxLName
            // 
            txtBoxLName.Location = new Point(125, 65);
            txtBoxLName.Name = "txtBoxLName";
            txtBoxLName.Size = new Size(239, 29);
            txtBoxLName.TabIndex = 1;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(30, 68);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(87, 21);
            lblLName.TabIndex = 19;
            lblLName.Text = "Last Name:";
            // 
            // txtBoxMName
            // 
            txtBoxMName.Location = new Point(125, 135);
            txtBoxMName.Name = "txtBoxMName";
            txtBoxMName.Size = new Size(239, 29);
            txtBoxMName.TabIndex = 3;
            txtBoxMName.TextChanged += textBox2_TextChanged;
            // 
            // lblMName
            // 
            lblMName.AutoSize = true;
            lblMName.Location = new Point(12, 138);
            lblMName.Name = "lblMName";
            lblMName.Size = new Size(107, 21);
            lblMName.TabIndex = 21;
            lblMName.Text = "Middle Name:";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(45, 173);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(74, 21);
            lblProgram.TabIndex = 23;
            lblProgram.Text = "Program:";
            // 
            // cmbBoxProgram
            // 
            cmbBoxProgram.FormattingEnabled = true;
            cmbBoxProgram.ItemHeight = 21;
            cmbBoxProgram.Items.AddRange(new object[] { "BSCS", "BSIT", "BSCpE", "BSBA", "BSAIS", "BSHM", "BACOMM", "BSTM" });
            cmbBoxProgram.Location = new Point(125, 170);
            cmbBoxProgram.Name = "cmbBoxProgram";
            cmbBoxProgram.Size = new Size(239, 29);
            cmbBoxProgram.TabIndex = 4;
            // 
            // txtBoxStudentNo
            // 
            txtBoxStudentNo.Location = new Point(125, 205);
            txtBoxStudentNo.Name = "txtBoxStudentNo";
            txtBoxStudentNo.Size = new Size(239, 29);
            txtBoxStudentNo.TabIndex = 5;
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(28, 208);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(91, 21);
            lblStudentNo.TabIndex = 25;
            lblStudentNo.Text = "Student No:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 275);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(84, 34);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmSignup
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 325);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxStudentNo);
            Controls.Add(lblStudentNo);
            Controls.Add(cmbBoxProgram);
            Controls.Add(lblProgram);
            Controls.Add(txtBoxMName);
            Controls.Add(lblMName);
            Controls.Add(txtBoxLName);
            Controls.Add(lblLName);
            Controls.Add(txtBoxFName);
            Controls.Add(lblFName);
            Controls.Add(btnSignUp);
            Controls.Add(txtBoxPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblSignup);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmSignup";
            Text = "Facility Assignment & Request System";
            Load += frmSignup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private TextBox txtBoxPassword;
        private Label lblPassword;
        private Label lblSignup;
        private TextBox txtBoxFName;
        private Label lblFName;
        private TextBox txtBoxLName;
        private Label lblLName;
        private TextBox txtBoxMName;
        private Label lblMName;
        private Label lblProgram;
        private ComboBox cmbBoxProgram;
        private TextBox txtBoxStudentNo;
        private Label lblStudentNo;
        private Button btnLogin;
    }
}