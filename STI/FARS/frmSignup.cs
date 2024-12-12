using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FARS
{
    public partial class frmSignup : Form
    {

        public frmSignup()
        {
            InitializeComponent();
        }
        public frmSignup(string StudentNo)
        {
            InitializeComponent();

            txtBoxStudentNo.Text = StudentNo;
        }
        private void switchLogin()
        {
            this.Hide();
            frmLogin li = new frmLogin();
            li.ShowDialog();
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string studentNo = txtBoxStudentNo.Text;
            string lName = txtBoxLName.Text;
            string fName = txtBoxFName.Text;
            string mName = txtBoxMName.Text;
            string program = cmbBoxProgram.Text;
            string password = ("[Password] " + txtBoxPassword.Text);
            string accountNo = ("[StudentNo] " + studentNo);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (Data.checkAccount(accountNo))
            {
                using (StreamWriter outFile = new StreamWriter(Path.Combine(path, "FARS\\data\\info.txt"), true))
                {
                    outFile.WriteLine(accountNo);
                    outFile.WriteLine(password);
                }
            }
            else
            {
                MessageBox.Show("Account already exists");
            }
            Data.inputAccInfo(studentNo, lName, fName, mName, program);
            switchLogin();
        }
        private void frmSignup_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            switchLogin();
        }
    }
}
