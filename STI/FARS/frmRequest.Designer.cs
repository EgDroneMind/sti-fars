namespace FARS
{
    partial class frmRequest
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
            cmbBoxFacility = new ComboBox();
            lblHeader = new Label();
            btnBack = new Button();
            lblFacility = new Label();
            rdBtnRoom = new RadioButton();
            lblType = new Label();
            rdBtnAirCon = new RadioButton();
            rdBtnTVComp = new RadioButton();
            rdBtnOther = new RadioButton();
            btnSubmit = new Button();
            rTxtBoxNotes = new RichTextBox();
            lblNotes = new Label();
            SuspendLayout();
            // 
            // cmbBoxFacility
            // 
            cmbBoxFacility.FormattingEnabled = true;
            cmbBoxFacility.Location = new Point(102, 63);
            cmbBoxFacility.Margin = new Padding(4);
            cmbBoxFacility.Name = "cmbBoxFacility";
            cmbBoxFacility.Size = new Size(281, 29);
            cmbBoxFacility.TabIndex = 1;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.MediumPurple;
            lblHeader.Location = new Point(15, 13);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(120, 37);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "Request";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(13, 373);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 31);
            btnBack.TabIndex = 3;
            btnBack.Text = "Cancel";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblFacility
            // 
            lblFacility.AutoSize = true;
            lblFacility.Location = new Point(35, 66);
            lblFacility.Name = "lblFacility";
            lblFacility.Size = new Size(60, 21);
            lblFacility.TabIndex = 4;
            lblFacility.Text = "Facility:";
            // 
            // rdBtnRoom
            // 
            rdBtnRoom.AutoSize = true;
            rdBtnRoom.Location = new Point(102, 99);
            rdBtnRoom.Name = "rdBtnRoom";
            rdBtnRoom.Size = new Size(130, 25);
            rdBtnRoom.TabIndex = 5;
            rdBtnRoom.TabStop = true;
            rdBtnRoom.Text = "Room Request";
            rdBtnRoom.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(50, 103);
            lblType.Name = "lblType";
            lblType.Size = new Size(45, 21);
            lblType.TabIndex = 6;
            lblType.Text = "Type:";
            // 
            // rdBtnAirCon
            // 
            rdBtnAirCon.AutoSize = true;
            rdBtnAirCon.Location = new Point(102, 130);
            rdBtnAirCon.Name = "rdBtnAirCon";
            rdBtnAirCon.Size = new Size(142, 25);
            rdBtnAirCon.TabIndex = 7;
            rdBtnAirCon.TabStop = true;
            rdBtnAirCon.Text = "Air Conditioning";
            rdBtnAirCon.UseVisualStyleBackColor = true;
            // 
            // rdBtnTVComp
            // 
            rdBtnTVComp.AutoSize = true;
            rdBtnTVComp.Location = new Point(102, 161);
            rdBtnTVComp.Name = "rdBtnTVComp";
            rdBtnTVComp.Size = new Size(139, 25);
            rdBtnTVComp.TabIndex = 8;
            rdBtnTVComp.TabStop = true;
            rdBtnTVComp.Text = "TV or Computer";
            rdBtnTVComp.UseVisualStyleBackColor = true;
            // 
            // rdBtnOther
            // 
            rdBtnOther.AutoSize = true;
            rdBtnOther.Location = new Point(102, 192);
            rdBtnOther.Name = "rdBtnOther";
            rdBtnOther.Size = new Size(68, 25);
            rdBtnOther.TabIndex = 9;
            rdBtnOther.TabStop = true;
            rdBtnOther.Text = "Other";
            rdBtnOther.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(302, 373);
            btnSubmit.Margin = new Padding(4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(82, 31);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // rTxtBoxNotes
            // 
            rTxtBoxNotes.Location = new Point(102, 223);
            rTxtBoxNotes.Name = "rTxtBoxNotes";
            rTxtBoxNotes.Size = new Size(282, 143);
            rTxtBoxNotes.TabIndex = 11;
            rTxtBoxNotes.Text = "";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(42, 226);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(54, 21);
            lblNotes.TabIndex = 12;
            lblNotes.Text = "Notes:";
            // 
            // frmRequest
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 417);
            Controls.Add(lblNotes);
            Controls.Add(rTxtBoxNotes);
            Controls.Add(btnSubmit);
            Controls.Add(rdBtnOther);
            Controls.Add(rdBtnTVComp);
            Controls.Add(rdBtnAirCon);
            Controls.Add(lblType);
            Controls.Add(rdBtnRoom);
            Controls.Add(lblFacility);
            Controls.Add(btnBack);
            Controls.Add(lblHeader);
            Controls.Add(cmbBoxFacility);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRequest";
            Text = "Facility Assignment & Request System";
            Load += frmRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbBoxFacility;
        private Label lblHeader;
        private Button btnBack;
        private Label lblFacility;
        private RadioButton rdBtnRoom;
        private Label lblType;
        private RadioButton rdBtnAirCon;
        private RadioButton rdBtnTVComp;
        private RadioButton rdBtnOther;
        private Button btnSubmit;
        private RichTextBox rTxtBoxNotes;
        private Label lblNotes;
    }
}