using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Controller
{
    class TerminController
    {
        public static TerminController theInstance = new TerminController();

        private TerminController() { }

        public List<TerminModel> termine = new List<TerminModel>();

        /// <summary>
        /// Erstellt anhand der Parameter einen Termin, welcher dann in die Liste geschrieben wird.
        /// </summary>
        /// <param name="pPerson"></param>
        /// <param name="pDatum"></param>
        /// <param name="pTreffpunkt"></param>
        /// <param name="pBeschreibung"></param>
        public void einfuegen(PersonModel pPerson, DateTime pDatum, String pTreffpunkt, String pBeschreibung)
        {
            TerminModel termin = new TerminModel(pPerson, pDatum, pTreffpunkt, pBeschreibung);
            termine.Add(termin);
        }

        /// <summary>
        /// Löscht einen Termin durch die parametrisierte ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public String loeschen(int id)
        {
            if (termine[id] != null)
            {
                termine.Remove(suchen(id));
                return "Der Termin wurde erfolgreich gelöscht";
            }
            else
            {
                return "Zu der angegebenen ID wurde kein Termin gefunden";
            }
        }

        /// <summary>
        /// Sucht einen Termin durch die parametrisierte ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TerminModel suchen(int id)
        {
            if (termine[id] != null)
            {
                return termine[id];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Sortiert die Liste entweder nach "nachname", "treffpunkt" oder "datum".
        /// </summary>
        /// <param name="pKriterium"></param>
        /// <returns></returns>
        public List<TerminModel> sortiere(String pKriterium)
        {
            if (termine.Count >= 1)
            {
                List<TerminModel> sortedList = new List<TerminModel>();
                switch (pKriterium)
                {
                    case "nachname":
                        sortedList = termine.OrderBy(termin => termin.person.nachname).ToList();
                        break;
                    case "treffpunkt":
                        sortedList = termine.OrderBy(termin => termin.treffpunkt).ToList();
                        break;
                    case "datum":
                        sortedList = termine.OrderBy(termin => termin.datum).ToList();
                        break;
                }
                return sortedList;
            }
            else
            {
                return null;
            }
        }
        public DateTime[] GetDateTimes()
        {
            DateTime[] daten = termine.Select(x => x.datum).ToArray();
            return daten;
        }
    }
}
