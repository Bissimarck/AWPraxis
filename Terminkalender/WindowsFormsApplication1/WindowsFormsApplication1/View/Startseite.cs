using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication1.Controller;
using WindowsFormsApplication1.Model;
using WindowsFormsApplication1.View;
using WindowsFormsApplication1.View.Personenverwaltung;

namespace WindowsFormsApplication1
{
    public partial class Startseite : Form
    {

        TerminController terminController = TerminController.theInstance;

        public Startseite()
        {
            InitializeComponent();
            monthCalendar1.BoldedDates = terminController.GetDateTimes();

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void personenverwaltung_button_Click(object sender, EventArgs e)
        {
            View.Personenverwaltung.Bericht bericht = new View.Personenverwaltung.Bericht();
            bericht.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.Terminverwaltung.Bericht bericht = new View.Terminverwaltung.Bericht();
            bericht.ShowDialog();
        }
    }
}
