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
            this.personCombo.DataSource = personenString;
        }

    private void abbrechenBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void speichernBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
