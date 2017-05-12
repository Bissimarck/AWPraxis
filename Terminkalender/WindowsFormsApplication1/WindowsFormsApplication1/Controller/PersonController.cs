using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Controller
{
    // Es wurde abgesprochen, dass nur maximal 20 Personen existieren dürfen
    public class PersonController
    {
        public static PersonController theInstance = new PersonController();

        private PersonController() { }

        public static PersonController Instance
        {
            get
            {
                return theInstance;
            }
        }

        public List<PersonModel> personen = new List<PersonModel>();

        /// <summary>
        /// Fuegt anhand der eingegebenen Parameter eine Person in die Liste 'personen' ein.
        /// </summary>
        /// <param name="pVorname"></param>
        /// <param name="pNachname"></param>
        /// <param name="pWohnort"></param>
        /// <param name="pAdresse"></param>
        /// <param name="pPLZ"></param>
        public void einfuegen(string pVorname, string pNachname, string pWohnort, string pAdresse, string pPLZ)
        {
            PersonModel person = new PersonModel(pNachname, pVorname, pWohnort, pAdresse, pPLZ);
            personen.Add(person);
        }

        /// <summary>
        /// Löscht anhand der angegebenen ID die Person, welche an dem Ort der Liste steht.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public String loeschen(int id)
        {
            if (personen[id] != null)
            {
                personen.Remove(suchen(id));
                return "Die Person wurde erfolgreich gelöscht";
            }
            else
            {
                return "Die Person wurde nicht gefunden";
            }
        }

        /// <summary>
        /// Sucht anhand der angegebenen ID die Person, welche an dem Ort der Liste steht.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PersonModel suchen(int id)
        {
            if (personen[id] != null)
            {
                return personen[id];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pKriterium"></param>
        /// <returns></returns>
        public List<PersonModel> sortiere(String pKriterium)
        {
            if (personen.Count >= 2)
            {
                List<PersonModel> sortedList = new List<PersonModel>();
                switch (pKriterium)
                {
                    case "nachname":
                        sortedList = personen.OrderBy(o => o.nachname).ToList();
                        break;
                    case "wohnort":
                        sortedList = personen.OrderBy(o => o.wohnort).ToList();
                        break;
                    case "plz":
                        sortedList = personen.OrderBy(o => o.plz).ToList();
                        break;
                }
                return sortedList;
            }
            else
            {
                return null;
            }
        }

        public string convertObjectToString(PersonModel person)
        {
            return person.vorname + " " + person.nachname + ", " + person.adresse + ", " + person.plz + " " + person.wohnort;
        }
    }
}
