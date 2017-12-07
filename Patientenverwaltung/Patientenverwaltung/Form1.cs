using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patientenverwaltung
{
    public partial class Patientenverwaltung : Form
    {
        public Patientenverwaltung()
        {
            InitializeComponent();
            List<Patient> test = Patient.auslesen();
            grid_Patienten.DataSource = test;

            grid_Patienten.Columns[4].Visible = false;
            grid_Patienten.Columns[5].Visible = false;
            grid_Patienten.Columns[7].Visible = false;
            grid_Patienten.Columns[8].Visible = false;
            grid_Patienten.Columns[9].Visible = false;
            grid_Patienten.Columns[1].Width = 248;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form createForm = new Create_Form2();
            createForm.ShowDialog();
        }
    }
}
