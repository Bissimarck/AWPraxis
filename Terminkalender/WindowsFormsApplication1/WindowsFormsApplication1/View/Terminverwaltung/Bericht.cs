using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controller;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.View.Terminverwaltung
{
    public partial class Bericht : Form
    {
        TerminController terminController = TerminController.theInstance;
        public Bericht()
        {
            InitializeComponent();
        }

        private void Bericht_Load(object sender, EventArgs e)
        {
            setzeDaten(terminController.termine);
        }

        private void speichereBtn_Click(object sender, EventArgs e)
        {

        }

        private void setzeDaten(List<TerminModel> liste)
        {
            listBox1.Items.Clear();
            foreach (TerminModel termin in liste)
            {
                String anzeige = termin.beschreibung + " am " + termin.datum.Day + "." + termin.datum.Month + "." + termin.datum.Year + ": " + termin.treffpunkt + " mit " + termin.person.nachname;
                listBox1.Items.Add(anzeige);
            }
        }

        private void sortiereNachnameBtn_Click(object sender, EventArgs e)
        {
            setzeDaten(terminController.sortiere("nachname"));
        }

        private void sortiereTreffpunktBtn_Click(object sender, EventArgs e)
        {
            setzeDaten(terminController.sortiere("treffpunkt"));
        }

        private void sortiereDatumBtn_Click(object sender, EventArgs e)
        {
            setzeDaten(terminController.sortiere("datum"));
        }

        private void speichereBtn_Click_1(object sender, EventArgs e)
        {
            Speichern speichernDialog = new Speichern();
            speichernDialog.ShowDialog();
            setzeDaten(terminController.termine);
        }
    }
}
