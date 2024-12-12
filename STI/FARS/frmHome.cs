using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FARS
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            extract();
            lblDate.Text = DateTime.Now.ToShortDateString();

        }

        private void extract()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] content = File.ReadAllLines(Path.Combine(path, "FARS\\data\\accounts\\" + frmLogin.StudentID + ".txt"));
            lblWelcome.Text = "Welcome! " + content[3];
            uSERNAMEToolStripMenuItem.Text = content[3].ToUpper();
            refresh();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
        }
        public void refresh() 
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] contents = File.ReadAllLines(Path.Combine(path, "FARS\\data\\accounts\\" + frmLogin.StudentID + "_request.txt"));
            int limit = Convert.ToInt32(contents[contents.Length - 1])+1;
            for (int i = 1; i < limit; i++ )
            {
                comboBox1.Items.Add(i);
            }
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchLogin();
        }
        private void switchLogin()
        {
            this.Hide();
            frmLogin li = new frmLogin();
            li.ShowDialog();
            this.Close();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void uSERNAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRequest req = new frmRequest();
            req.ShowDialog();
            this.Close();
        }

        public void update()
        {
            string type="";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] contents = File.ReadAllLines(Path.Combine(path, "FARS\\data\\accounts\\" + frmLogin.StudentID + "_request.txt"));
            int i = Convert.ToInt32(comboBox1.Text);
            i = (i * 5) - 4;
            lblRequest.Text = "Request No. " + comboBox1.Text;
            lblFacility.Text = contents[i];
            switch (Convert.ToInt32(contents[i+1])) 
            {
                case 0:
                    type = "Room Request";
                    break;
                case 1:
                    type = "Air Conditioning";
                    break;
                case 2:
                    type = "TV or Computer";
                    break;
                case 3:
                    type = "Other";
                    break;
            }
            lblType.Text = type;
            lblNotes.Text = contents[i+2];
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void lblFacility_Click(object sender, EventArgs e)
        {

        }
    }
}
