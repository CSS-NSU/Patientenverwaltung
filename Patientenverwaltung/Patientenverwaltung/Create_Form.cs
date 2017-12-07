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
    public partial class Create_Form2 : Form
    {
        public Create_Form2()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Patient derNeue = new Patient();
            derNeue.Krankenkasse = txt_Krankenkasse.Text;
            derNeue.Versicherungsnummer = txt_Versicherungsnummer.Text;
            derNeue.Vorname = txt_Vorname.Text;
            derNeue.Nachname = txt_Nachname.Text;
            derNeue.Plz = Convert.ToInt32(txt_Ort.Text);
            derNeue.Geburtsdatum = Convert.ToDateTime(txt_Geburtsdatum.Text);
            derNeue.Telefon = Convert.ToInt32(txt_Telefon.Text);
            derNeue.Besonderheiten = txt_Besonderheiten.Text;
            derNeue.reinschreiben();

            Close();
        }
    }
}
