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

namespace WindowsFormsApplication1.View.Personenverwaltung
{
    public partial class Bericht : Form
    {
        PersonController personController = PersonController.theInstance;
        
        public Bericht()
        {
            InitializeComponent();
        }

        private void Bericht_Load(object sender, EventArgs e)
        {
            setzeDaten(personController.personen);
        }

        private void setzeDaten(List<PersonModel> liste)
        {
            listBox1.Items.Clear();
            foreach (PersonModel person in liste)
            {
                listBox1.Items.Add(personController.convertObjectToString(person));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
              setzeDaten(personController.sortiere("nachname"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setzeDaten(personController.sortiere("plz"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setzeDaten(personController.sortiere("wohnort"));
        }

        private void loeschenBtn_Click(object sender, EventArgs e)
        {

        }

        private void speichereBtn_Click(object sender, EventArgs e)
        {
            Speichern speichernDialog = new Speichern();
            speichernDialog.ShowDialog();
            setzeDaten(personController.personen);
        }
    }
}
