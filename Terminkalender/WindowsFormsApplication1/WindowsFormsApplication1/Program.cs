using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication1.Controller;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initialisiereKalender();
            Application.Run(new Startseite());
        }

        static void initialisiereKalender()
        {
            PersonController personenController = PersonController.theInstance;
            personenController.einfuegen("Jonas", "Pfeiffer", "Oberhausen", "Hellberg 1", "46047");
            personenController.einfuegen("Dustin", "Riepl",  "Bottrop", "Gladbecker Straße 5", "46240");
            personenController.einfuegen("Pierre", "Lasarzig",  "Essen", "Altenessener Straße 4123", "12456");

            List<PersonModel> personen = new List<PersonModel>();
            for (int i = 0; i < personenController.personen.Count; i++)
            {
                personen.Add(personenController.suchen(i));
            }

            TerminController terminController = TerminController.theInstance;
            terminController.einfuegen(personen[0], new DateTime(
                2017, 5, 5), "Schule Frankenstraße", "Unterricht");
            terminController.einfuegen(personen[1], new DateTime(
                2017, 5, 6), "Schule Dahnstraße", "Unterricht");
            terminController.einfuegen(personen[2], new DateTime(
                2017, 5, 7), "Schule Frankenstraße", "Unterricht");
        }
    }
}
