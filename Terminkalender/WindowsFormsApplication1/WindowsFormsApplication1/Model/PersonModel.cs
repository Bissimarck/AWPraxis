using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    public class PersonModel
    {
        public PersonModel(string pNachname, string pVorname, string pWohnort, string pAdresse, string pPlz)
        {
            nachname = pNachname;
            vorname = pVorname;
            wohnort = pWohnort;
            adresse = pAdresse;
            plz = pPlz;
        }

        public PersonModel()
        {
        }

        public string nachname;
        public string vorname;
        public string wohnort;
        public string adresse;
        public string plz;
    }
}
