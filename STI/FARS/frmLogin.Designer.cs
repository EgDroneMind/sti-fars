namespace FARS
{
    partial class frmLogin
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
            lblLogin = new Label();
            lblStudentNo = new Label();
            txtBoxStudentNo = new TextBox();
            txtBoxPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.MediumPurple;
            lblLogin.Location = new Point(12, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(97, 37);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Log In";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(12, 70);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(91, 21);
            lblStudentNo.TabIndex = 1;
            lblStudentNo.Text = "Student No:";
            // 
            // txtBoxStudentNo
            // 
            txtBoxStudentNo.Location = new Point(109, 67);
            txtBoxStudentNo.Name = "txtBoxStudentNo";
            txtBoxStudentNo.Size = new Size(335, 29);
            txtBoxStudentNo.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(109, 102);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(335, 29);
            txtBoxPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 105);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(360, 151);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(84, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(12, 151);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(84, 34);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 207);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtBoxStudentNo);
            Controls.Add(lblStudentNo);
            Controls.Add(lblLogin);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmLogin";
            Text = "Facility Assignment & Request System";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblStudentNo;
        private TextBox txtBoxStudentNo;
        private TextBox txtBoxPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnSignUp;
    }
}
