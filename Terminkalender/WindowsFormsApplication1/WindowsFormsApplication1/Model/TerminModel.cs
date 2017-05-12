using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class TerminModel
    {
        public TerminModel(PersonModel pPerson, DateTime pDatum, String pTreffpunkt, String pBeschreibung)
        {
            person = pPerson;
            datum = pDatum;
            treffpunkt = pTreffpunkt;
            beschreibung = pBeschreibung;
        }

        public PersonModel person;
        public DateTime datum;
        public String treffpunkt;
        public String beschreibung;
    }
}
