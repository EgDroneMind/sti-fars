namespace FARS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void switchSignup() 
        {
            this.Hide();
            frmHome home = new frmHome();
            home.ShowDialog();
            this.Close();
        }
        public static string StudentID;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string checkU = ("[StudentNo] " + txtBoxStudentNo.Text);
            string checkP = ("[Password] " + txtBoxPassword.Text);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] inputFiles = File.ReadAllLines(Path.Combine(path, "FARS\\data\\info.txt"));
            StudentID = txtBoxStudentNo.Text;
            for (int i = 0; i + 1 < inputFiles.Length; i += 2)
            {
                if (checkU == inputFiles[i])
                {
                    if (checkP == inputFiles[i + 1])
                    {
                        Data data = new Data();
                        switchSignup();
                    }
                    else
                    {
                        MessageBox.Show("Password is Incorrect.\nPlease try again.");
                    }
                }
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignup su = new frmSignup(txtBoxStudentNo.Text);
            su.ShowDialog();
            this.Close();
        }
    }
}
