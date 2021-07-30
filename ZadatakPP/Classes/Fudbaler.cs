using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    
    public class Fudbaler
    {
        private string slika;
        private string ime;
        private int broj;
        private DateTime datumRodjenja;
        private string pozicija;
        private string rtfFajl;

        public string Slika { get => slika; set => slika = value; }
        public string Ime { get => ime; set => ime = value; }
        public int Broj { get => broj; set => broj = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Pozicija { get => pozicija; set => pozicija = value; }
        public string RtfFajl { get => rtfFajl; set => rtfFajl = value; }

        public Fudbaler()
        {
            RtfFajl = "";
            Slika = "";
            Ime = "";
            Broj = 0;
            DatumRodjenja = new DateTime(2019, 1, 1);
            Pozicija = "";

        }

        public Fudbaler(string rtfFajl,string slika, string ime,  DateTime datumRodjenja, int broj, string pozicija)
        {
            RtfFajl = rtfFajl;
            Slika = slika;
            Ime = ime;
            Broj = broj;
            DatumRodjenja = datumRodjenja;
            Pozicija = pozicija;
        }
    }
}
