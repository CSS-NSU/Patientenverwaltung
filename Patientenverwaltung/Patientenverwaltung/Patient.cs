using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Patientenverwaltung
{
    class Patient
    {
        private Guid id = Guid.NewGuid();
        private string krankenkasse = ".,mnbvcx";
        private string versicherungsnummer = "";
        private string vorname = "";
        private string nachname = "";
        private string strasse = "";
        private int plz = 00000;
        private DateTime geburtsdatum = DateTime.Now;
        private int telefon = 0000;
        private string besonderheiten = "";
        private static string path = @"H:\Documents\Patienten.txt";

        public string Krankenkasse
        {
            get
            {
                return krankenkasse;
            }

            set
            {
                krankenkasse = value;
            }
        }

        public string Versicherungsnummer
        {
            get
            {
                return versicherungsnummer;
            }

            set
            {
                versicherungsnummer = value;
            }
        }

        public string Vorname
        {
            get
            {
                return vorname;
            }

            set
            {
                vorname = value;
            }
        }

        public string Nachname
        {
            get
            {
                return nachname;
            }

            set
            {
                nachname = value;
            }
        }

        public string Strasse
        {
            get
            {
                return strasse;
            }

            set
            {
                strasse = value;
            }
        }

        public int Plz
        {
            get
            {
                return plz;
            }

            set
            {
                plz = value;
            }
        }

        public DateTime Geburtsdatum
        {
            get
            {
                return geburtsdatum;
            }

            set
            {
                geburtsdatum = value;
            }
        }

        public int Telefon
        {
            get
            {
                return telefon;
            }

            set
            {
                telefon = value;
            }
        }

        public string Besonderheiten
        {
            get
            {
                return besonderheiten;
            }

            set
            {
                besonderheiten = value;
            }
        }

        public Guid Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public void reinschreiben()
        {

            string text = File.ReadAllText(path);

            List<Patient> listPatient = new List<Patient>();

            if (!string.IsNullOrWhiteSpace(text))
            {
                listPatient = JsonConvert.DeserializeObject<List<Patient>>(text);
            }

            listPatient.Add(this);
            
            string output = JsonConvert.SerializeObject(listPatient);
            File.WriteAllText(path , output);
        }

        public static List<Patient> auslesen()
        {
            try
            {
                List<Patient> ret = new List<Patient>();
                string text = File.ReadAllText(path);
                if (!string.IsNullOrWhiteSpace(text))
                {
                    List<Patient> tempList = JsonConvert.DeserializeObject<List<Patient>>(text);
                    foreach(Patient p in tempList){
                        ret.Add(p);
                    }
                }
                return ret;
            }
            catch(Exception ex)
            {
                return new List<Patient>();
            }
            
        }
    }
}
