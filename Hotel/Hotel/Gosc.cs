using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Gosc
    {
        string imie;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        string nazwisko;

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public Gosc(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public override string ToString()
        {
            return "Gość, " + imie + " " + nazwisko;
        }
    }
}
