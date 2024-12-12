namespace FARS
{
    partial class frmHome
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
            lblHeader = new Label();
            lblWelcome = new Label();
            menuStrip1 = new MenuStrip();
            uSERNAMEToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            lblDate = new Label();
            btnBook = new Button();
            panelDisplay = new Panel();
            lblNotes = new Label();
            lblType = new Label();
            lblFacility = new Label();
            lblTitleNotes = new Label();
            lblTitleType = new Label();
            lblTitleFacility = new Label();
            lblRequest = new Label();
            comboBox1 = new ComboBox();
            lblNo = new Label();
            menuStrip1.SuspendLayout();
            panelDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.MediumPurple;
            lblHeader.Location = new Point(12, 25);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(157, 37);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Dashboard";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(32, 69);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(164, 25);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome! $user$";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { uSERNAMEToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(626, 35);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = " ";
            // 
            // uSERNAMEToolStripMenuItem
            // 
            uSERNAMEToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            uSERNAMEToolStripMenuItem.BackColor = Color.Transparent;
            uSERNAMEToolStripMenuItem.DoubleClickEnabled = true;
            uSERNAMEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            uSERNAMEToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uSERNAMEToolStripMenuItem.ForeColor = Color.MediumPurple;
            uSERNAMEToolStripMenuItem.Margin = new Padding(50, 10, 20, 0);
            uSERNAMEToolStripMenuItem.Name = "uSERNAMEToolStripMenuItem";
            uSERNAMEToolStripMenuItem.Size = new Size(89, 21);
            uSERNAMEToolStripMenuItem.Text = "USERNAME";
            uSERNAMEToolStripMenuItem.Click += uSERNAMEToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "Log out";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(506, 106);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(108, 21);
            lblDate.TabIndex = 4;
            lblDate.Text = "MM/DD/YYYY";
            lblDate.Click += lblDate_Click;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(506, 134);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(108, 28);
            btnBook.TabIndex = 6;
            btnBook.Text = "Request";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // panelDisplay
            // 
            panelDisplay.BackColor = SystemColors.GradientInactiveCaption;
            panelDisplay.BorderStyle = BorderStyle.Fixed3D;
            panelDisplay.Controls.Add(lblNotes);
            panelDisplay.Controls.Add(lblType);
            panelDisplay.Controls.Add(lblFacility);
            panelDisplay.Controls.Add(lblTitleNotes);
            panelDisplay.Controls.Add(lblTitleType);
            panelDisplay.Controls.Add(lblTitleFacility);
            panelDisplay.Controls.Add(lblRequest);
            panelDisplay.Location = new Point(32, 106);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(468, 261);
            panelDisplay.TabIndex = 7;
            // 
            // lblNotes
            // 
            lblNotes.Location = new Point(72, 105);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(389, 108);
            lblNotes.TabIndex = 9;
            // 
            // lblType
            // 
            lblType.Location = new Point(131, 73);
            lblType.Name = "lblType";
            lblType.Size = new Size(330, 31);
            lblType.TabIndex = 8;
            // 
            // lblFacility
            // 
            lblFacility.Location = new Point(73, 42);
            lblFacility.Name = "lblFacility";
            lblFacility.Size = new Size(388, 31);
            lblFacility.TabIndex = 7;
            lblFacility.Click += lblFacility_Click;
            // 
            // lblTitleNotes
            // 
            lblTitleNotes.AutoSize = true;
            lblTitleNotes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleNotes.Location = new Point(8, 105);
            lblTitleNotes.Name = "lblTitleNotes";
            lblTitleNotes.Size = new Size(58, 21);
            lblTitleNotes.TabIndex = 6;
            lblTitleNotes.Text = "Notes:";
            // 
            // lblTitleType
            // 
            lblTitleType.AutoSize = true;
            lblTitleType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleType.Location = new Point(8, 73);
            lblTitleType.Name = "lblTitleType";
            lblTitleType.Size = new Size(117, 21);
            lblTitleType.TabIndex = 5;
            lblTitleType.Text = "Request Type: ";
            // 
            // lblTitleFacility
            // 
            lblTitleFacility.AutoSize = true;
            lblTitleFacility.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleFacility.Location = new Point(10, 42);
            lblTitleFacility.Name = "lblTitleFacility";
            lblTitleFacility.Size = new Size(67, 21);
            lblTitleFacility.TabIndex = 4;
            lblTitleFacility.Text = "Facility: ";
            // 
            // lblRequest
            // 
            lblRequest.AutoSize = true;
            lblRequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequest.Location = new Point(10, 9);
            lblRequest.Name = "lblRequest";
            lblRequest.Size = new Size(115, 21);
            lblRequest.TabIndex = 3;
            lblRequest.Text = "Request No. #";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(506, 228);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 29);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(506, 204);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(94, 21);
            lblNo.TabIndex = 4;
            lblNo.Text = "Request No.";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 399);
            Controls.Add(lblNo);
            Controls.Add(comboBox1);
            Controls.Add(panelDisplay);
            Controls.Add(btnBook);
            Controls.Add(lblDate);
            Controls.Add(menuStrip1);
            Controls.Add(lblWelcome);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmHome";
            Text = "Facility Assignment & Request System";
            Load += frmHome_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelDisplay.ResumeLayout(false);
            panelDisplay.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblWelcome;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem uSERNAMEToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Label lblDate;
        private Button btnBook;
        private Panel panelDisplay;
        private Button button2;
        private Button button1;
        private Label lblRequest;
        private ComboBox comboBox1;
        private Label lblNo;
        private Label lblTitleFacility;
        private Label lblTitleType;
        private Label lblNotes;
        private Label lblType;
        private Label lblFacility;
        private Label lblTitleNotes;
    }
}