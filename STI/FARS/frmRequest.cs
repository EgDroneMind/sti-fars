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
    public partial class frmRequest : Form
    {
        public frmRequest()
        {
            InitializeComponent();
            getFacility();
        }

        private void frmRequest_Load(object sender, EventArgs e)
        {

        }
        private void getFacility()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FARS\\data\\facility.txt");
            if (File.Exists(path))
            {
                string[] inFiles = File.ReadAllLines(path);
                foreach (string inFile in inFiles)
                {
                    cmbBoxFacility.Items.Add(inFile);
                }
            }
            else
            {
                using (StreamWriter outFile = new StreamWriter(path))
                {
                    outFile.WriteLine("Classroom (2nd Floor)");
                    outFile.WriteLine("Classroom (3rd Floor)");
                    outFile.WriteLine("Classroom (4th Floor)");
                    outFile.WriteLine("Classroom (5th Floor)");
                    outFile.WriteLine("Classroom (6th Floor)");
                    outFile.WriteLine("Classroom (7th Floor)");
                    outFile.WriteLine("Computer Lab (3rd Floor)");
                    outFile.WriteLine("Computer Lab (4th Floor)");
                    outFile.WriteLine("Computer Lab (5th Floor)");
                    outFile.WriteLine("Computer Lab (6th Floor)");
                    outFile.WriteLine("Computer Lab (7th Floor)");
                    outFile.WriteLine("Lobby");
                    outFile.WriteLine("Chemistry Lab (3rd Floor)");
                    outFile.WriteLine("Kitchen (4th Floor)");
                    outFile.WriteLine("Kitchen (5th Floor)");
                    outFile.WriteLine("Dance Studio (5th Floor)");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int requestType=3;
            if (rdBtnRoom.Checked)
            {
                requestType = 0;
            }
            else if (rdBtnAirCon.Checked) 
            {
                requestType = 1;
            }
            else if (rdBtnTVComp.Checked) 
            {
                requestType = 2;
            }
            else if (rdBtnOther.Checked) 
            {
                requestType = 3;
            }
            string notes;
            if (rTxtBoxNotes.Text.Trim().Equals(String.Empty))
            {
                notes = "no notes";
            }
            else 
            {
                notes = rTxtBoxNotes.Text;
            }

            Data.encodeRequest(cmbBoxFacility.Text, requestType, notes);
            frmHome home = new frmHome();
            this.Hide();
            home.refresh();
            home.ShowDialog();
            this.Close();
        }
    }
}
