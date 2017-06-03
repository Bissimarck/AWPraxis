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
using WindowsFormsApplication1.View.Personenverwaltung;

namespace WindowsFormsApplication1.View
{
    public partial class Speichern : Form
    {
        PersonController persoController = PersonController.theInstance;

        public Speichern()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string isError = "Fehler:";
            string vorname = vornameInput.Text;
            string nachname = nachnameInput.Text;
            string wohnort = wohnortInput.Text;
            string adresse = adresseInput.Text;
            string plz = plzInput.Text;

            if (vorname.Length <= 0 || vorname.Length > 50)
            {
                isError = String.Concat(isError," Vorname ist ungültig");
            }

            if (nachname.Length <= 0 || nachname.Length > 50)
            {
                if (isError.Length > 7)
                {
                    isError = String.Concat(isError,", Nachname ist ungültig");
                }
                else
                {
                    isError = String.Concat(isError, " Nachname ist ungültig");
                }
            }

            if (wohnort.Length <= 0 || wohnort.Length > 50)
            {
                if (isError.Length > 7)
                {
                    isError = isError + ", Wohnort ist ungültig";
                }
                else
                {
                    isError = isError + " Wohnort ist ungültig";
                }
            }

            if (adresse.Length <= 0 || adresse.Length > 100)
            {
                if (isError.Length > 7)
                {
                    isError = isError + ", Adresse ist ungültig";
                }
                else
                {
                    isError = isError + " Adresse ist ungültig";
                }
            }

            if (plz.Length <= 0 || plz.Length > 16)
            {
                if (isError.Length > 7)
                {
                    isError = isError + ", PLZ ist ungültig";
                }
                else
                {
                    isError = isError + " PLZ ist ungültig";
                }
            }

            if (isError.Length < 8)
            {
                Bericht berichtView = new Bericht();
                persoController.einfuegen(vornameInput.Text, nachnameInput.Text, wohnortInput.Text, adresseInput.Text, plzInput.Text);
                this.Dispose();
            }
            else
            {
                MessageBox.Show(isError, "Invalide eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
