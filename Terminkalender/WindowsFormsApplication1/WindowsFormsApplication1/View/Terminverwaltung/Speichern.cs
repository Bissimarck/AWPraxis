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
    public partial class Speichern : Form
    {
        PersonController personController = PersonController.theInstance;
        TerminController terminController = TerminController.theInstance;
        List<PersonModel> personen = new List<PersonModel>();

        public Speichern()
        {
            InitializeComponent();
            personen = personController.personen;
            List<string> personenString = new List<string>();
            foreach(PersonModel person in personen)
            {
                personenString.Add(personController.convertObjectToString(person));
            }
            this.personSelect.DataSource = personenString;
        }

    private void abbrechenBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void speichernBtn_Click(object sender, EventArgs e)
        {
            string isError = "Fehler:";
            string location = locationInput.Text;
            string description = descriptionInput.Text;

            if (location.Length <= 0 || location.Length > 255)
            {
                if (isError.Length > 7)
                {
                    isError = String.Concat(isError, ", Treffpunkt ist ungültig");
                }
                else
                {
                    isError = String.Concat(isError, " Treffpunkt ist ungültig");
                }
            }

            if (description.Length <= 0 || description.Length > 255)
            {
                if (isError.Length > 7)
                {
                    isError = isError + ", Beschreibung ist ungültig";
                }
                else
                {
                    isError = isError + " Beschreibung ist ungültig";
                }
            }

            if (isError.Length < 8)
            {
                Bericht berichtView = new Bericht();

                PersonModel person = personSelect;

                DateTime date = this.dateTimePicker.Value.Date;

                terminController.einfuegen(person, date, locationInput.Text, descriptionInput.Text);
                this.Dispose();
            }
            else
            {
                MessageBox.Show(isError, "Invalide eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
